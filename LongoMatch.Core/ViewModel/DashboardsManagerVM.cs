﻿//
//  Copyright (C) 2016 Fluendo S.A.
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using VAS.Core.Common;
using VAS.Core.Interfaces.MVVMC;
using VAS.Core.MVVMC;
using VAS.Core.Store;
using VAS.Core.Store.Templates;
using VAS.Core.ViewModel;
using VAS.Core.Resources.Styles;
using System.Collections.Generic;
using VAS.Core;
using System;

namespace LongoMatch.Core.ViewModel
{
	public class DashboardsManagerVM : TemplatesManagerViewModel<Dashboard, DashboardVM, DashboardButton, DashboardButtonVM>, IDashboardDealer
	{
		CountLimitationBarChartVM chartVM;

		public DashboardsManagerVM ()
		{
			AddButton = LoadedTemplate.AddButton;
			NewCommand.Icon = App.Current.ResourcesLocator.LoadIcon ("vas-add", Sizes.TemplatesIconSize);
			NewCommand.IconName = "vas-add";
			SaveCommand.Icon = App.Current.ResourcesLocator.LoadIcon ("vas-save", Sizes.TemplatesIconSize);
			DeleteCommand.Icon = App.Current.ResourcesLocator.LoadIcon ("vas-delete", Sizes.TemplatesIconSize);
			DeleteCommand.IconName = "vas-delete";
			ExportCommand.Icon = App.Current.ResourcesLocator.LoadIcon ("lm-export", Sizes.TemplatesIconSize);
			ImportCommand.Icon = App.Current.ResourcesLocator.LoadIcon ("vas-import", Sizes.TemplatesIconSize);
			TransferCommand = new Command (() => throw new NotImplementedException ()) {
				Icon = App.Current.ResourcesLocator.LoadIcon ("lm-transfer", Sizes.TemplatesIconSize),
				IconName = "lm-transfer"
			};
			MakeDefaultCommand = new Command (() => throw new NotImplementedException ()) {
				Icon = App.Current.ResourcesLocator.LoadIcon ("lm-select", Sizes.TemplatesIconSize),
				IconName = "lm-select"
			};

			if (LimitationChart != null) {
				LimitationChart.Dispose ();
				LimitationChart = null;
			}
		}

		public Command<string> AddButton {
			get;
			private set;
		}

		/// <summary>
		/// Calls the transfer service holding the current Dashboard.
		/// </summary>
		/// <value>The transfer command.</value>
		public Command TransferCommand {
			get;
			private set;
		}

		/// <summary>
		/// Marks dashboard as default
		/// </summary>
		/// <value>The make default command.</value>
		public Command MakeDefaultCommand {
			get;
			private set;
		}

		public DashboardVM Dashboard {
			get {
				return LoadedTemplate;
			}
		}

		/// <summary>
		/// ViewModel for the Bar chart used to display count limitations in the Limitation Widget
		/// </summary>
		public CountLimitationBarChartVM LimitationChart {
			get { return chartVM; }
			set {
				chartVM = value;
				Limitation = chartVM?.Limitation;
			}
		}

		protected override MenuVM CreateMenu (IViewModel vm)
		{
			DeleteCommand.IconName = "vas-delete";
			MenuVM menu = new MenuVM ();
			menu.ViewModels.AddRange (new List<MenuNodeVM> {
				new MenuNodeVM (DeleteCommand, vm, Catalog.GetString("Delete")) { ActiveColor = App.Current.Style.ColorAccentError },
			});

			return menu;
		}

		protected override DashboardVM CreateInstance (Dashboard model)
		{
			var vm = base.CreateInstance (model);
			if (model.Static) {
				StaticViewModels.Add (vm);
			}

			return vm;
		}
	}
}