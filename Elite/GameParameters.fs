module GameParameters

open DomainModels
open System

let commodities = [
    {BasePrice=0x13; Gradient=(-0x02); Basequant=0x06; Mask=0x01; Units=0; Name="Food        "}
    {BasePrice=0x14; Gradient=(-0x01); Basequant=0x0A; Mask=0x03; Units=0; Name="Textiles    "}
    {BasePrice=0x41; Gradient=(-0x03); Basequant=0x02; Mask=0x07; Units=0; Name="Radioactives"}
    {BasePrice=0x28; Gradient=(-0x05); Basequant=0xE2; Mask=0x1F; Units=0; Name="Slaves      "}
    {BasePrice=0x53; Gradient=(-0x05); Basequant=0xFB; Mask=0x0F; Units=0; Name="Liquor/Wines"}
    {BasePrice=0xC4; Gradient=(+0x08); Basequant=0x36; Mask=0x03; Units=0; Name="Luxuries    "}
    {BasePrice=0xEB; Gradient=(+0x1D); Basequant=0x08; Mask=0x78; Units=0; Name="Narcotics   "}
    {BasePrice=0x9A; Gradient=(+0x0E); Basequant=0x38; Mask=0x03; Units=0; Name="Computers   "}
    {BasePrice=0x75; Gradient=(+0x06); Basequant=0x28; Mask=0x07; Units=0; Name="Machinery   "}
    {BasePrice=0x4E; Gradient=(+0x01); Basequant=0x11; Mask=0x1F; Units=0; Name="Alloys      "}
    {BasePrice=0x7C; Gradient=(+0x0d); Basequant=0x1D; Mask=0x07; Units=0; Name="Firearms    "}
    {BasePrice=0xB0; Gradient=(-0x09); Basequant=0xDC; Mask=0x3F; Units=0; Name="Furs        "}
    {BasePrice=0x20; Gradient=(-0x01); Basequant=0x35; Mask=0x03; Units=0; Name="Minerals    "}
    {BasePrice=0x61; Gradient=(-0x01); Basequant=0x42; Mask=0x07; Units=1; Name="Gold        "}
    {BasePrice=0xAB; Gradient=(-0x02); Basequant=0x37; Mask=0x1F; Units=1; Name="Platinum    "}
    {BasePrice=0x2D; Gradient=(-0x01); Basequant=0xFA; Mask=0x0F; Units=2; Name="Gem-Stones  "}
    {BasePrice=0x35; Gradient=(+0x0F); Basequant=0xC0; Mask=0x07; Units=0; Name="Alien Items "}
]                            

let descriptionList = [
    {OptionOne="fabled"; OptionTwo="notable"; OptionThree="well known"; OptionFour="famous"; OptionFive="noted"}
    {OptionOne="very"; OptionTwo="mildly"; OptionThree="most"; OptionFour="reasonably"; OptionFive=""}
    {OptionOne="ancient"; OptionTwo="\x95"; OptionThree="great"; OptionFour="vast"; OptionFive="pink"}
    {OptionOne="\x9E \x9D plantations"; OptionTwo="mountains"; OptionThree="\x9C"; OptionFour="\x94 forests"; OptionFive="oceans"}
    {OptionOne="shyness"; OptionTwo="silliness"; OptionThree="mating traditions"; OptionFour="loathing of \x86"; OptionFive="love for \x86"}
    {OptionOne="food blenders"; OptionTwo="tourists"; OptionThree="poetry"; OptionFour="discos"; OptionFive="\x8E"}
    {OptionOne="talking tree"; OptionTwo="crab"; OptionThree="bat"; OptionFour="lobst"; OptionFive="\xB2"}
    {OptionOne="beset"; OptionTwo="plagued"; OptionThree="ravaged"; OptionFour="cursed"; OptionFive="scourged"}
    {OptionOne="\x96 civil war"; OptionTwo="\x9B \x98 \x99s"; OptionThree="a \x9B disease"; OptionFour="\x96 earthquakes"; OptionFive="\x96 solar activity"}
    {OptionOne="its \x83 \x84"; OptionTwo="the \xB1 \x98 \x99"; OptionThree="its inhabitants' \x9A \x85"; OptionFour="\xA1"; OptionFive="its \x8D \x8E"}
    {OptionOne="juice"; OptionTwo="brandy"; OptionThree="water"; OptionFour="brew"; OptionFive="gargle blasters"}
    {OptionOne="\xB2"; OptionTwo="\xB1 \x99"; OptionThree="\xB1 \xB2"; OptionFour="\xB1 \x9B"; OptionFive="\x9B \xB2"}
    {OptionOne="fabulous"; OptionTwo="exotic"; OptionThree="hoopy"; OptionFour="unusual"; OptionFive="exciting"}
    {OptionOne="cuisine"; OptionTwo="night life"; OptionThree="casinos"; OptionFour="sit coms"; OptionFive=" \xA1 "}
    {OptionOne="\xB0"; OptionTwo="The planet \xB0"; OptionThree="The world \xB0"; OptionFour="This planet"; OptionFive="This world"}
    {OptionOne="n unremarkable"; OptionTwo=" boring"; OptionThree=" dull"; OptionFour=" tedious"; OptionFive=" revolting"}
    {OptionOne="planet"; OptionTwo="world"; OptionThree="place"; OptionFour="little planet"; OptionFive="dump"}
    {OptionOne="wasp"; OptionTwo="moth"; OptionThree="grub"; OptionFour="ant"; OptionFive="\xB2"}
    {OptionOne="poet"; OptionTwo="arts graduate"; OptionThree="yak"; OptionFour="snail"; OptionFive="slug"}
    {OptionOne="tropical"; OptionTwo="dense"; OptionThree="rain"; OptionFour="impenetrable"; OptionFive="exuberant"}
    {OptionOne="funny"; OptionTwo="wierd"; OptionThree="unusual"; OptionFour="strange"; OptionFive="peculiar"}
    {OptionOne="frequent"; OptionTwo="occasional"; OptionThree="unpredictable"; OptionFour="dreadful"; OptionFive="deadly"}
    {OptionOne="\x82 \x81 for \x8A"; OptionTwo="\x82 \x81 for \x8A and \x8A"; OptionThree="\x88 by \x89"; OptionFour="\x82 \x81 for \x8A but \x88 by \x89"; OptionFive="a\x90 \x91"}
    {OptionOne="\x9B"; OptionTwo="mountain"; OptionThree="edible"; OptionFour="tree"; OptionFive="spotted"}
    {OptionOne="\x9F"; OptionTwo="\xA0"; OptionThree="\x87oid"; OptionFour="\x93"; OptionFive="\x92"}
    {OptionOne="ancient"; OptionTwo="exceptional"; OptionThree="eccentric"; OptionFour="ingrained"; OptionFive="\x95"}
    {OptionOne="killer"; OptionTwo="deadly"; OptionThree="evil"; OptionFour="lethal"; OptionFive="vicious"}
    {OptionOne="parking meters"; OptionTwo="dust clouds"; OptionThree="ice bergs"; OptionFour="rock formations"; OptionFive="volcanoes"}
    {OptionOne="plant"; OptionTwo="tulip"; OptionThree="banana"; OptionFour="corn"; OptionFive="\xB2weed"}
    {OptionOne="\xB2"; OptionTwo="\xB1 \xB2"; OptionThree="\xB1 \x9B"; OptionFour="inhabitant"; OptionFive="\xB1 \xB2"}
    {OptionOne="shrew"; OptionTwo="beast"; OptionThree="bison"; OptionFour="snake"; OptionFive="wolf"}
    {OptionOne="leopard"; OptionTwo="cat"; OptionThree="monkey"; OptionFour="goat"; OptionFive="fish"}
    {OptionOne="\x8C \x8B"; OptionTwo="\xB1 \x9F \xA2"; OptionThree="its \x8D \xA0 \xA2"; OptionFour="\xA3 \xA4"; OptionFive="\x8C \x8B"}
    {OptionOne="meat"; OptionTwo="cutlet"; OptionThree="steak"; OptionFour="burgers"; OptionFive="soup"}
    {OptionOne="ice"; OptionTwo="mud"; OptionThree="Zero-G"; OptionFour="vacuum"; OptionFive="\xB1 ultra"}
    {OptionOne="hockey"; OptionTwo="cricket"; OptionThree="karate"; OptionFour="polo"; OptionFive="tennis"}
]

let printHelp =
    printfn "Welcome to F# Elite"
    printfn ""
    printfn "Commands are:"
    printfn "buy   tradegood amount"
    printfn "sell  tradegood amount"
    printfn "fuel  amount     (buy amount LY of fuel)"
    printfn "jump  planetname (limited by fuel)"
    printfn "sneak planetname (any distance - no fuel cost)"
    printfn "galhyp           (jumps to next galaxy)"
    printfn "info  planetname (prints info on system)"
    printfn "mkt              (shows market prices)"
    printfn "local            (lists systems within max range of your ship)"
    printfn "cash number      (alters cash - cheating!)"
    printfn "hold number      (change cargo bay)"
    printfn "quit, exit or ^Z (exit)"
    printfn "help command     (help for a particular command)"
    printfn "intro            (display this text)"
    printfn "run filepath     (run a file of commands - one per line)"
    printfn "Some commands have abbreviations f = fuel, j = jump,"
    printfn "b = buy, s = sell etc"
    printfn ""

//let buy command amount =
 
let displayMarket () =
    commodities |> List.iter (fun x -> printfn "%s " x.Name)    

let processCommand command =
    match command with
    | "buy" | "b" -> printfn "Hi buy"
    | "sell" | "s" -> printfn "Let's sell!"
    | "fuel" | "f" -> printfn "Gimme fuel"
    | "jump" | "j" -> printfn "Jump away"
    | "sneak" -> printfn "Walk quietly"
    | "galhyp" -> printfn "Jump galaxy"
    | "info" -> printfn "Tell me more"
    | "mkt" -> displayMarket ()
    | "local" -> printfn "Nearby systems"
    | "cash" -> printfn "More money"
    | "hold" -> printfn "Change bay"
    | "quit" | "exit" -> Environment.Exit(0)
    | "help" -> printfn "How can we help?"
    | "intro" -> printHelp
    | _ -> printfn "Invalid command"

let currentCargoSize spaceShip =
    spaceShip.Cargo |> Seq.sumBy (fun i -> i.Units)

let calculateRemainingHoldCapacity spaceShip =
    spaceShip.HoldSize - currentCargoSize(spaceShip)
