﻿using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using Excel2PDFWinUi.Contracts.ViewModels;
using Excel2PDFWinUi.Core.Contracts.Services;
using Excel2PDFWinUi.Core.Models;

namespace Excel2PDFWinUi.ViewModels;

public partial class CompanyListViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public CompanyListViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
