// ---------------------------------------------------------------
// Copyright (c) Brian Parker. All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

namespace DynamicLayout.Views.Shared
{
    using System;
    using DynamicLayout.Services;
    using Microsoft.AspNetCore.Components;

    public class SetFooter : ComponentBase, IDisposable
    {
        [Inject]
        private ILayoutService Layout { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void OnInitialized()
        {
            if (Layout != null)
            {
                Layout.FooterSetter = this;
            }
            base.OnInitialized();
        }

        protected override bool ShouldRender()
        {
            var shouldRender = base.ShouldRender();
            if (shouldRender)
            {
                Layout.UpdateFooter();
            }
            return shouldRender;
        }
        
        public void Dispose()
        {
            if (Layout != null)
            {
                Layout.FooterSetter = null;
            }
        }
    }
}
