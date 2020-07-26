using System.Collections.Generic;


using Exiled.API.Interfaces;

using UnityEngine;

namespace RemoteKeycard
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;


    }
}
