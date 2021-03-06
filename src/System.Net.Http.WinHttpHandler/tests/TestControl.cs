// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading;

namespace WinHttpHandlerTests
{
    public static class TestControl
    {
        public static bool WinHttpAutomaticProxySupport { get; set; }

        public static bool WinHttpDecompressionSupport { get; set; }

        public static int LastWin32Error { get; set; }

        public static bool WinHttpAPIFail { get; set; }

        public static bool PACFileNotDetectedOnNetwork { get; set; }

        public static int ResponseDelayTime { get; set; }

        public static AutoResetEvent ResponseDelayCompletedEvent { get; internal set; }

        public static void Reset()
        {
            WinHttpAutomaticProxySupport = true;
            WinHttpDecompressionSupport = true;

            LastWin32Error = 0;
            WinHttpAPIFail = false;

            PACFileNotDetectedOnNetwork = false;
            ResponseDelayTime = 0;
            ResponseDelayCompletedEvent = new AutoResetEvent(true);
        }

        public static void ResetAll()
        {
            APICallHistory.Reset();
            FakeRegistry.Reset();
            TestControl.Reset();
            TestServer.Reset();
        }
    }
}
