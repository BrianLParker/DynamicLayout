// ---------------------------------------------------------------
// Copyright (c) Brian Parker. All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

namespace DynamicLayout.Services
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using DynamicLayout.Views.Shared;
    using Microsoft.AspNetCore.Components;

    public class LayoutService : ILayoutService, INotifyPropertyChanged
    {

        public RenderFragment Footer => FooterSetter?.ChildContent;
        public RenderFragment Header => HeaderSetter?.ChildContent;

        public SetFooter FooterSetter
        {
            get => footerSetter;
            set
            {
                if (footerSetter == value) return;
                footerSetter = value;
                UpdateFooter();
            }
        }
        public SetHeader HeaderSetter
        {
            get => headerSetter;
            set
            {
                if (headerSetter == value) return;
                headerSetter = value;
                UpdateHeader();
            }
        }

        public void UpdateFooter() => NotifyPropertyChanged(nameof(Footer));
        public void UpdateHeader() => NotifyPropertyChanged(nameof(Header));

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private SetFooter footerSetter;
        private SetHeader headerSetter;

    }


}
