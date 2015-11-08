module DomainModels

open System.Collections.Generic

type DescriptionList = {
    OptionOne   : string
    OptionTwo   : string
    OptionThree : string
    OptionFour  : string
    OptionFive  : string
}

type Commodity = {
    BasePrice : int
    Gradient : int
    Basequant : int
    Mask : int
    Units : int
    Name : string
}

type MarketGood = {
    Price : int
    Quantity : int
}

type Market = {
    Goods : Dictionary<Commodity, MarketGood>
}

type PlanetarySystem = {
    X : int
    Y : int
    Economy : int
    GovernmentType : int
    TechnologyLevel : int
    Population : int
    Productivity : int
    Radius : int
    Name : string
    //GoatSoupSeed : int
}

type SpaceShip = {
    HoldSize : int
    Cargo : List<Commodity>
    Cash : int
    MaximumFuelCapacity : int
    CurrentGalaxyNumber : int
    CurrentPlanetNumber : int
}