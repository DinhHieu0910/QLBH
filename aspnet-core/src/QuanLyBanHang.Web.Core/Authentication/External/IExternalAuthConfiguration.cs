﻿using System.Collections.Generic;

namespace QuanLyBanHang.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
