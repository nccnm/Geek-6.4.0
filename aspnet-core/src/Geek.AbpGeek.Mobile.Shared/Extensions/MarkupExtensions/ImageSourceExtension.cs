﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Geek.AbpGeek.Extensions.MarkupExtensions
{
    [ContentProperty(nameof(Source))]
    public class ImageSourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Source == null ? null : ImageSource.FromResource(Source);
        }
    }
}
