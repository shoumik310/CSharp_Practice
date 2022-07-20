// See https://aka.ms/new-console-template for more information
PhotoProcessor photoProcess = new();

//PhotoProcessor.PhotoFilterHandler photoFilterHandler 
Action<Photo> photoFilterHandler = PhotoFilters.IncreaseBrightness;
photoFilterHandler += PhotoFilters.IncreaseSaturations;

photoProcess.Process("Image.jpg",photoFilterHandler);
