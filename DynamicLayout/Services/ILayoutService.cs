// ---------------------------------------------------------------
// Copyright (c) Brian Parker. All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

namespace DynamicLayout.Services
{
    using System.ComponentModel;
    using DynamicLayout.Views.Shared;
    using Microsoft.AspNetCore.Components;

    public interface ILayoutService
{
    RenderFragment Footer { get; }
    RenderFragment Header { get; }
    SetFooter FooterSetter { get; set; }
    SetHeader HeaderSetter { get; set; }
    event PropertyChangedEventHandler PropertyChanged;
    void UpdateFooter();
    void UpdateHeader();
}


}
