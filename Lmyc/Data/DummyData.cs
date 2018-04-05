using Lmyc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lmyc.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Boat> getBoats()
        {
            List<Boat> boats = new List<Boat>()
            {
                new Boat()
                {
                    BoatName = "Sharqui",
                    BoatDescription = "Sharqui was added to the fleet in 2016.  Another of the very popular C&C designs for style, comfort, and speed. Sharqui sleeps five comfortably, has an aftermarket outboard motor, and sports a very generous dodger for protection on heavy weather days.",
                    BoatLength = 27,
                    BoatMake = "C&ampC",
                    BoatYear = 1981
                },
                new Boat()
                {
                    BoatName = "Pegasus",
                    BoatDescription = "Pegasus will be oufitted for travelling to Desolation Sound for the first time this summer. Members are looking forward to a roomier more comfortable boat with generous side decks.",
                    BoatLength = 27,
                    BoatMake = "C&ampC",
                    BoatYear = 1979
                },
                new Boat()
                {
                    BoatName = "Lightcure",
                    BoatDescription = "She is one of our most popular boats, being a good sailor and comfortable while cruising.She sleeps 5 adults comfortably. She was refitted in 2005 and is powered by a remote controlled Yamaha outboard. Lightcure has a BBQ, cockpit table, asymmetrical spinnaker and all the extras to be comfortable for cruising.She is also rigged for use in local sailboat races.",
                    BoatLength = 27,
                    BoatMake = "C&ampC",
                    BoatYear = 1979
                },
                new Boat()
                {
                    BoatName = "Frankie",
                    BoatDescription = "She is designated as a “day sailor”, and is available for use in Semiahmoo Bay. She is outfitted with some of the amenities for cruising and may be used occasionally for overnight trips. She might sleep 4 adults comfortably.Frankie has a spray dodger and is powered by a Yamaha outboard.",
                    BoatLength = 25,
                    BoatMake = "Cal Mark 2",
                    BoatYear = 1983
                },
                new Boat()
                {
                    BoatName = "White Swan",
                    BoatDescription = "She is a cruising boat, with a spray dodger, inboard diesel engine and enclosed head. White Swan is popular for longer trips to the local islands.She sleeps 4 adults very comfortably with a private aft cabin and V-berth",
                    BoatLength = 28.31,
                    BoatMake = "Catalina 28 MkII",
                    BoatYear = 1991
                },
                new Boat()
                {
                    BoatName = "Peak Time",
                    BoatDescription = "She has a spray dodger, BBQ and a comfortable cockpit. She has all the amenities and can be used as a cruiser or day sailing boat. She can sleep 4 adults. Peak Time is powered by a Yamaha outboard engine. She is also rigged for use in local sailboat races.",
                    BoatLength = 27,
                    BoatMake = "C&ampC Mark 5",
                    BoatYear = 1985
                },
                new Boat()
                {
                    BoatName = "Y-Knot",
                    BoatDescription = "A spacious fast cruiser. She has a comfortable cockpit, spray dodger. She has all the amenities of a cruiser.Large aft head/shower. She can sleep up to 6 adults in comfort. Powered by a Yanmar diesel. Stable wing keel design. Open transom with swim grid, BBQ for sailing adventures. She is a cruising boat, with a spray dodger, inboard diesel engine and enclosed head. White Swan is popular for longer trips to the local islands.She sleeps 4 adults very comfortably with a private aft cabin and V-berth",
                    BoatLength = 30,
                    BoatMake = "Hunter 30 Cruiser/Racer",
                    BoatYear = 1974
                }

            };

            return boats;
        }
    }
}
