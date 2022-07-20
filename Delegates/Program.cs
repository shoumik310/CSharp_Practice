// See https://aka.ms/new-console-template for more information
PhotoProcessor photoProcess = new();

PhotoProcessor.PhotoFilterHandler photoFilterHandler = PhotoFilters.IncreaseBrightness;
photoFilterHandler += PhotoFilters.IncreaseSaturations;

photoProcess.Process("Image.jpg",photoFilterHandler);
