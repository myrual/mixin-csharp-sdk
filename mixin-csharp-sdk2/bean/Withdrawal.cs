﻿using System;
namespace MixinSdk.Bean
{
    public class WithDrawalReq
    {
        public string amount { get; set; }
        public string address_id { get; set; }
        public string memo { get; set; }
        public string pin { get; set; }
        public string trace_id { get; set; }
    }

    public class WithDrawalRsp
    {
        public string type { get; set; }
        public string snapshot_id { get; set; }
        public string transaction_hash { get; set; }
        public string asset_id { get; set; }
        public string amount { get; set; }
        public string trace_id { get; set; }
        public string memo { get; set; }
        public string created_at { get; set; }
    }

}
