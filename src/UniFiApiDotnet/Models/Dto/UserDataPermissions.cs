using System;
using System.Text.Json.Serialization;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class UserDataPermissions : IUserDataPermissions
    {
        [JsonPropertyName("innerspace.management")]
        public string[] InnerSpaceManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("led.management")]
        public string[] LedManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("protect.management")]
        public string[] ProtectManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("talk.management")]
        public string[] TalkManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("access.management")]
        public string[] AccessManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("calculus.management")]
        public string[] CalculusManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("connect.management")]
        public string[] ConnectManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("drive.management")]
        public string[] DriveManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("olympus.management")]
        public string[] OlympusManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("network.management")]
        public string[] NetworkManagement { get; set; } = Array.Empty<string>();

        [JsonPropertyName("system.management.user")]
        public string[] SystemManagementUser { get; set; } = Array.Empty<string>();

        [JsonPropertyName("system.management.location")]
        public string[] SystemManagementLocation { get; set; } = Array.Empty<string>();
    }
}