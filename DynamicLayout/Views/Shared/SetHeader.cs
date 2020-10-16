// ---------------------------------------------------------------
// Copyright (c) Brian Parker. All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

namespace DynamicLayout.Views.Shared
{
    using System;
    using DynamicLayout.Services;
    using Microsoft.AspNetCore.Components;

    public class SetHeader : ComponentBase, IDisposable
    {
        [Inject]
        private ILayoutService Layout { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void OnInitialized()
        {
            if (Layout != null)
            {
                Layout.HeaderSetter = this;
            }
            base.OnInitialized();
        }

        protected override bool ShouldRender()
        {
            var shouldRender = base.ShouldRender();
            if (shouldRender)
            {
                Layout.UpdateHeader();
            }
            return shouldRender;
        }

        public void Dispose()
        {
            if (Layout != null)
            {
                Layout.HeaderSetter = null;
            }
        }

    }
}
