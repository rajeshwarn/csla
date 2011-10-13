﻿using System;

namespace WpUI.ViewModels
{
  /// <summary>
  /// Base viewmodel type for use with model types that are
  /// NOT loaded from the app server (either child business
  /// types, or a viewmodel created from an already-loaded
  /// object).
  /// </summary>
  public class ViewModelLocal<T> : Csla.Xaml.ViewModelBase<T>
  {

  }
}
