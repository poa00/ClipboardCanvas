﻿using ClipboardCanvas.Shared.ComponentModel;
using System.ComponentModel;

namespace ClipboardCanvas.Sdk.Services.Settings
{
    /// <summary>
    /// An interface for storing application configuration and settings.
    /// </summary>
    public interface IAppSettings : IPersistable, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets the value containing information about the app theme.
        /// </summary>
        string? ApplicationTheme { get; set; }

        /// <summary>
        /// Gets or sets the last version number used before an update.
        /// </summary>
        string? LastVersion { get; set; }

        /// <summary>
        /// Gets or sets the app language preference.
        /// </summary>
        string? AppLanguage { get; set; }
    }
}