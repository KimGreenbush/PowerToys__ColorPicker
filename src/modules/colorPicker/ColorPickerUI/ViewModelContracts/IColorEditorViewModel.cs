// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;
using ColorPicker.Models;

namespace ColorPicker.ViewModelContracts
{
    public interface IColorEditorViewModel
    {
        event EventHandler OpenColorPickerRequested;

        ICommand OpenColorPickerCommand { get; }

        ICommand RemoveColorCommand { get; }

        ICommand RemoveAllColorsCommand { get; }

        ICommand ExportColorsCommand { get; }

        ObservableCollection<ColorFormatModel> ColorRepresentations { get; }

        ObservableCollection<Color> ColorsHistory { get; }

        Color SelectedColor { get; set; }

        int SelectedColorIndex { get; set; }

        void Initialize();

        string ColorName { get; }

        /// <summary>
        /// Gets a value indicating whether gets the show color name
        /// </summary>
        bool ShowColorName { get; }
    }
}
