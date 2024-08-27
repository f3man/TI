using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ShipmentTracker
{
    private static readonly HttpClient client = new HttpClient();
    private string apiKey = "your_api_key_here";

    public async Task<string> TrackShipmentAsync(string trackingNumber)
    {
        string url = $"https://api.shippingprovider.com/track?tracking_number={trackingNumber}&api_key={apiKey}";

        try
        {
            HttpResponseMessage response = await client.GetAsync(url);
            string responseData = await response.Content.ReadAsStringAsync();

            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(responseData);
            string status = data.data.status;
            string estimatedDelivery = data.data.estimated_delivery;
            string currentLocation = data.data.current_location;

            return $"Status: {status}, Estimated Delivery: {estimatedDelivery}, Current Location: {currentLocation}";
        }
        catch (Exception ex)
        {
            // Return a generic error message
            return "Error: Unable to retrieve tracking information.";
        }
    }
}
