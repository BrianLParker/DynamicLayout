// ---------------------------------------------------------------
// Copyright (c) Brian Parker. All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

namespace DynamicLayout.Views.Shared
{
    using DynamicLayout.Services;
    using Microsoft.AspNetCore.Components;
    using System;
    using System.ComponentModel;

    public partial class AppFooter : ComponentBase, IDisposable
    {
        [Inject]
        public ILayoutService LayoutService { get; set; }

        protected override void OnInitialized()
        {
            LayoutService.PropertyChanged += LayoutService_PropertyChanged;
            base.OnInitialized();
        }
        private void LayoutService_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ILayoutService.Footer))
            {
                StateHasChanged();
            }
        }
        public void Dispose()
        {
            if (LayoutService != null)
            {
                LayoutService.PropertyChanged -= LayoutService_PropertyChanged;
            }
        }
    }
}