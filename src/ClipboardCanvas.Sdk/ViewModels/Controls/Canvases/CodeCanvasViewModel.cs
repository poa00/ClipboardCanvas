﻿using System.IO;
using ClipboardCanvas.Sdk.Extensions;
using ClipboardCanvas.Sdk.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using OwlCore.Storage;
using System.Threading;
using System.Threading.Tasks;

namespace ClipboardCanvas.Sdk.ViewModels.Controls.Canvases
{
    public partial class CodeCanvasViewModel : BaseCanvasViewModel
    {
        /// <inheritdoc/>
        public override IStorable? Storable { get; }

        [ObservableProperty] private string? _Text;
        [ObservableProperty] private string? _Language;

        public CodeCanvasViewModel(IFile codeFile, IDataSourceModel sourceModel)
            : base(sourceModel)
        {
            Language = Path.GetExtension(codeFile.Id);
            Storable = codeFile;
        }

        /// <inheritdoc/>
        public override async Task InitAsync(CancellationToken cancellationToken = default)
        {
            if (Storable is not IFile file)
                return;

            Text = await file.ReadAllTextAsync(null, cancellationToken);
        }
    }
}
