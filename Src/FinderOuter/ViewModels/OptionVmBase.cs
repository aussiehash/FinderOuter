﻿// The FinderOuter
// Copyright (c) 2020 Coding Enthusiast
// Distributed under the MIT software license, see the accompanying
// file LICENCE or http://www.opensource.org/licenses/mit-license.php.

using FinderOuter.Backend;
using FinderOuter.Models;
using ReactiveUI;

namespace FinderOuter.ViewModels
{
    /// <summary>
    /// Base (abstract) class for view models that are supposed to be shown in the list of "options" in main window.
    /// </summary>
    public abstract class OptionVmBase : ViewModelBase
    {
        public abstract string OptionName { get; }
        public abstract string Description { get; }

        private Report _res = new Report();
        public Report Result
        {
            get => _res;
            set => this.RaiseAndSetIfChanged(ref _res, value);
        }

        public string MissingToolTip => ConstantsFO.MissingToolTip;

        public IReactiveCommand FindCommand { get; protected set; }
        public abstract void Find();
    }
}
