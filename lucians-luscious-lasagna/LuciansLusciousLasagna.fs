module LuciansLusciousLasagna

// TODO: define the 'expectedMinutesInOven' binding
let expectedMinutesInOven: int = 40

// define the 'minutesPerLayer' binding
let minutesPerLayer: int = 2

// TODO: define the 'remainingMinutesInOven' function
let remainingMinutesInOven (actualMinutesInOven: int): int =
    expectedMinutesInOven - actualMinutesInOven

// TODO: define the 'preparationTimeInMinutes' function
let preparationTimeInMinutes (numOfLayers: int): int = 
    numOfLayers * minutesPerLayer

// TODO: define the 'elapsedTimeInMinutes' function
let elapsedTimeInMinutes (numOfLayers: int) (actualMinutesInOven: int): int = 
    preparationTimeInMinutes numOfLayers + actualMinutesInOven