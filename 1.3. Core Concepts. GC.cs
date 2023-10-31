
        int[] pinObject = new int[1000];
        GCHandle handle = GCHandle.Alloc(pinObject, GCHandleType.Pinned);
        handle.Free();

// 