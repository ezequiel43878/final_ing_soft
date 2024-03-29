﻿using System.Windows;

namespace Parcial_Ing_Soft.Helpers
{
    public static class DialogCloser
    {
        public static readonly DependencyProperty DialogResultProperty =
        DependencyProperty.RegisterAttached(
        "DialogResult",
        typeof(bool?),
        typeof(DialogCloser),
        new PropertyMetadata(DialogResultChanged));

        private static void DialogResultChanged(
        DependencyObject d,
        DependencyPropertyChangedEventArgs e)
        {
            var window = d as Window;
            if (window != null)
                window.Close();
        }
        public static void SetDialogResult(Window target, bool? value)
        {
            target.SetValue(DialogResultProperty, value);
        }
    }
}
