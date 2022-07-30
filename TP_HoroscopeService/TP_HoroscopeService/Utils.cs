using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TP_HoroscopeService.DB_HoroscopeService;

namespace TP_HoroscopeService
{
    public class Utils
    {

        //Provides as random string message
        public static string RandomMsg()
        {
            string result = "";
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 7);

            if (RandomNumber == 1)
            {
                result = "Bleep Blop Bloop!"; 
            } else if (RandomNumber == 2)
            {
                result = "May the Force be with you";
            } else if (RandomNumber == 3)
            {
                result = "Live long and prosper";
            } else if (RandomNumber == 4)
            {
                result = "Strike me down in anger and I'll always be with you. Just like your father.";
            } else if (RandomNumber == 5)
            {
                result = "I'm sorry, Dave. I'm afraid I can't do that...";
            } else if (RandomNumber == 6)
            {
                result = "Ever have that feeling where you're not sure if you're awake or dreaming?";
            }

            return result;
        }


        //Calculate Age
        public static int CalculateAge(DateTime BirthDay, DateTime CurrentDate)
        {

            int Age = 0;
            Age = CurrentDate.Year - BirthDay.Year;
            if (CurrentDate.DayOfYear < BirthDay.DayOfYear)
                Age = Age - 1;
            return Age;
        }

        // Returns an astroogical sign and description bassed on user's birthday

        public static List<string> AstologicalSign(DateTime BirthDay)
        {

            List<string> SignResult = new List<string>() {"", "", ""};

            if ((BirthDay.Month == 3 && BirthDay.Day >= 21) || (BirthDay.Month == 4 && BirthDay.Day <= 19))
            {
                SignResult[0] = "Aries";
                SignResult[1] = "Every year, the sun enters Aries on the same day as the Spring Equinox. " +
                    "This is the starting point of the zodiac and the astrological year. Ruled by fiery and " +
                    "intense Mars, Aries season is full of light and energy. It’s one of the two times each year " +
                    "when the sun shines directly on the equator. Marked by the newborn Ram archetype, " +
                    "Aries season is all about embracing new beginnings and feeling alive as we channel our " +
                    "inner warrior and fearlessly reach for our goals. Impulsivity and aggressiveness are the " +
                    "negative expressions of Aries season, which can be channeled through active sports and healthy competition";
                SignResult[2] = "The first sign of the zodiac, Aries loves to be number one. Naturally, " +
                    "this dynamic fire sign is no stranger to competition. Bold and ambitious, " +
                    "Aries dives headfirst into even the most challenging situations—and they'll make sure they always come out on top!";
            }
            else if ((BirthDay.Month == 4 && BirthDay.Day >= 20) || (BirthDay.Month == 5 && BirthDay.Day <= 20))
            {
                SignResult[0] = "Taurus";
                SignResult[1] = "After a month of so much excitement, the sun enters Taurus and suddenly the vibe mellows out and our natural rhythm slows a few notches. " +
                    "As the days warm, we now take the time to stop and smell the roses and see the flowers bloom. We are now under the spell of pleasure goddess Venus, " +
                    "when touch, smell, taste, sound, and sight deepen and reach their highest expression. " +
                    "Our five senses are reawakened, reenergized, and refocused on our appreciation of nature, art, and all things beautiful. Being one of the most sensual signs, " +
                    "the nocturnal energy of Taurus loves rest and relaxation, which, of course, can sometimes make us a little lazy.";
                SignResult[2] = "What sign is more likely to take a six-hour bath, followed by a luxurious Swedish massage and decadent dessert spread? " +
                    "Why Taurus, of course! Taurus is an earth sign represented by the bull. Like their celestial spirit animal, " +
                    "Taureans enjoy relaxing in serene, bucolic environments surrounded by soft sounds, soothing aromas, and succulent flavors.";
            }
            else if ((BirthDay.Month == 5 && BirthDay.Day >= 21) || (BirthDay.Month == 6 && BirthDay.Day <= 20))
            {
                SignResult[0] = "Gemini";
                SignResult[1] = "Then comes playful Gemini season, a time to socialize not only with our faves, but also with new and exciting faces. " +
                    "The sign of the Twins is ruled by intellectual cosmic messenger Mercury, the fastest-moving planet in the solar system. " +
                    "Following its swift steps, we feel jittery and jump from one get-together to the next—and how could we not? " +
                    "It’s the middle of summer and there’s so much fun to be had! " +
                    "Another Gemini season signature is communication in all its forms: writing, speaking, reading, and learning. " +
                    "Of all the zodiac signs, Gemini is the one that best embodies the concept of sacred duality. At a deeper level, " +
                    "it’s also an opportunity to explore that same concept within us.";
                SignResult[2] = "Have you ever been so busy that you wished you could clone yourself just to get everything done? " +
                    "That's the Gemini experience in a nutshell. Spontaneous, playful, and adorably erratic, " +
                    "Gemini is driven by its insatiable curiosity. Appropriately symbolized by the celestial twins, " +
                    "this air sign was interested in so many pursuits that it had to double itself.";
            }
            else if ((BirthDay.Month == 6 && BirthDay.Day >= 21) || (BirthDay.Month == 7 && BirthDay.Day <= 22))
            {
                SignResult[0] = "Cancer";
                SignResult[1] = "Every year, the sun enters Cancer on the same day as the Summer Solstice. Ruled by the maternal and nocturnal moon, " +
                    "this month is about getting cozy, cooking, eating delicious food, and chilling out with the ones we love. " +
                    "It’s also the perfect time to get in touch with our emotions and to spend time near the water, " +
                    "whether it’s a beach, lake, or river. Self-care is another activity the sign of the Crab loves, " +
                    "because it’s the type of energy that connects us to our bodies. But don’t confuse self-care with passivity! " +
                    "Like the tenacious Crab, this is also the season to be assertive about getting what we want.";
                SignResult[2] = "Represented by the crab, Cancer seamlessly weaves between the sea and shore representing Cancer’s ability " +
                    "to exist in both emotional and material realms. Cancers are highly intuitive and their psychic abilities manifest in tangible spaces. " +
                    "But—just like the hard-shelled crustaceans—this water sign is willing to do whatever it takes to protect itself emotionally. " +
                    "In order to get to know this sign, you're going to need to establish trust!";
            }
            else if ((BirthDay.Month == 7 && BirthDay.Day >= 23) || (BirthDay.Month == 8 && BirthDay.Day <= 22))
            {
                SignResult[0] = "Leo";
                SignResult[1] = "We’ve been focusing on self-care and we’re now ready to shine our brightest! " +
                    "We’ve reached Leo season, the peak of summer and the only month that’s ruled by the mighty sun. " +
                    "During the month ahead, Leo’s sunny influence wants us to get in touch with our creativity, our inner child, " +
                    "and what makes us truly unique. Vibrant and playful Leo season is all about embracing big, bold vitality, " +
                    "beauty, and what lights our inner fire. This season activates our zodiac sign, " +
                    "so there is no better time to meditate on what it means to be a Libra, Scorpio, Pisces, or any other sign.";
                SignResult[2] = "Roll out the red carpet because Leo has arrived. Passionate, loyal, and infamously dramatic, " +
                    "Leo is represented by the lion and these spirited fire signs are the kings and queens of the celestial jungle. " +
                    "They're delighted to embrace their royal status: Vivacious, theatrical, and fiery, " +
                    "Leos love to bask in the spotlight and celebrate… well, themselves.";
            }
            else if ((BirthDay.Month == 8 && BirthDay.Day >= 23) || (BirthDay.Month == 9 && BirthDay.Day <= 22))
            {
                SignResult[0] = "Virgo";
                SignResult[1] = "Life has been entertaining, but once the sun enters Virgo, our mood becomes a bit more introverted. " +
                    "The mind is increasingly activated as we shift into mercurial territory. Like Gemini season, " +
                    "Virgo is ruled by communicative Mercury, except this is the nocturnal, not diurnal, manifestation of our cosmic messenger. " +
                    "We become master analysts and organizers, fine-tuning the routines that keep life working at its best." +
                    " Wellness, efficiency, and logic are all Virgo’s expertise, naturally gravitating us toward life practices that nurture body and soul. " +
                    "Being the studious worker bee of the zodiac, Virgo provides the perfect milieu to organize our finances and workload through efficient systems like apps and spreadsheets.";
                SignResult[2] = "You know the expression, \"if you want something done, give it to a busy person?\" " +
                    "Well, that definitely is the Virgo anthem. Virgos are logical, practical, and systematic in their approach to life. " +
                    "Virgo is an earth sign historically represented by the goddess of wheat and agriculture, " +
                    "an association that speaks to Virgo's deep-rooted presence in the material world. " +
                    "This earth sign is a perfectionist at heart and isn’t afraid to improve skills through diligent and consistent practice.";
            }
            else if ((BirthDay.Month == 9 && BirthDay.Day >= 23) || (BirthDay.Month == 10 && BirthDay.Day <= 22))
            {
                SignResult[0] = "Libra";
                SignResult[1] = "Libra season begins on the day we welcome the Fall Equinox. Ruled by Venus, " +
                    "Libra season is all about enjoying the pleasures of life and classy things like high-end design, trendy clothes, and long, " +
                    "lavish dinners with our VIPs. Attuning us to the diurnal energy of Venus, " +
                    "the month ruled by Libra is a very social time in which we nurture our most important connections and friendships. " +
                    "Harmony and equilibrium are also part of Libra’s realm, making this the best time of year to balance the masculine and feminine energies within us. " +
                    "Beautifying the home is also advised during this time, as Venus turns our eyes to all things aesthetic.";
                SignResult[2] = "Balance, harmony, and justice define Libra energy. As a cardinal air sign, " +
                    "Libra is represented by the scales (interestingly, the only inanimate object of the zodiac), " +
                    "an association that reflects Libra's fixation on establishing equilibrium. " +
                    "Libra is obsessed with symmetry and strives to create equilibrium in all areas of life — especially when it comes to matters of the heart.";
            }
            else if ((BirthDay.Month == 10 && BirthDay.Day >= 22) || (BirthDay.Month == 11 && BirthDay.Day <= 21))
            {
                SignResult[0] = "Scorpio";
                SignResult[1] = "Just as the air begins to cool in the Northern Hemisphere, so does the vibe around us. " +
                    "We have arrived at one of the most introspective times of the year because bold Scorpio is all about going inward and psychoanalyzing our deepest, " +
                    "darkest motives. It’s also the time when we celebrate the departed as well as our ancestral line. Ruled by transformative Pluto and red-hot Mars, " +
                    "Scorpio season is primed for tapping into our sexual energy as the most sacred form of creation. " +
                    "Tricky to maneuver, no-nonsense Scorpionic energy is not for the faint of heart, " +
                    "and only those who dare to go deep in its journey of transformation will experience its profound riches.";
                SignResult[2] = "Elusive and mysterious, Scorpio is one of the most misunderstood signs of the zodiac. " +
                    "Scorpio is a water sign that uses emotional energy as fuel, cultivating powerful wisdom through both the physical and unseen realms. " +
                    "In fact, Scorpio derives its extraordinary courage from its psychic abilities, which is what makes this sign one of the most complicated, " +
                    "dynamic signs of the zodiac.";
            }
            else if ((BirthDay.Month == 11 && BirthDay.Day >= 22) || (BirthDay.Month == 12 && BirthDay.Day <= 21))
            {
                SignResult[0] = "Sagittarius";
                SignResult[1] = "The lights are back on again as the sun enters the sign of never-ending optimism: the sign of the Archer! " +
                    "Like its mythical symbol the Centaur, Sagittarius is all about chasing the horizon, either physically or metaphorically. " +
                    "Now is when we yearn for knowledge, and adventure is expanded by the abundant influence of our greatest benefic Jupiter. " +
                    "Being one of the most positive planets in astrology, it wants us to see the big picture and believe the best in others " +
                    "and ourselves. Long-distance travel is also encouraged by this worldly sign, because travel exposes us to the richness " +
                    "that only other cultures can provide.";
                SignResult[2] = "Oh, the places Sagittarius goes! But… actually. This fire sign knows no bounds. Represented by the archer, " +
                    "Sagittarians are always on a quest for knowledge. The last fire sign of the zodiac, " +
                    "Sagittarius launches its many pursuits like blazing arrows, chasing after geographical, intellectual, and spiritual adventures.";
            }
            else if ((BirthDay.Month == 12 && BirthDay.Day >= 22) || (BirthDay.Month == 1 && BirthDay.Day <= 19))
            {
                SignResult[0] = "Capricorn";
                SignResult[1] = "Once the sun enters industrious Capricorn, it’s time to get down to business! This traditional, " +
                    "pragmatic, ambitious sign knows how to climb the tallest mountains in order to build something of enduring meaning. " +
                    "Capricorn season is ruled by Saturn, the old sage and keeper of time, ultimately bringing our awareness to how well we use it. " +
                    "Often referred to as the CEO of the zodiac, goal-oriented Capricorn connects us with the more material side of life like success, " +
                    "money, and social status. Out of all the seasons, this is the one in which to channel our inner boss" +
                    " as we chase our most precious goals and go for the gold.";
                SignResult[2] = "What is the most valuable resource? For Capricorn, the answer is clear: Time. " +
                    "Capricorn is climbing the mountain straight to the top and knows that patience, perseverance, " +
                    "and dedication is the only way to scale. The last earth sign of the zodiac, Capricorn, is represented by the sea-goat, " +
                    "a mythological creature with the body of a goat and the tail of a fish. Accordingly, " +
                    "Capricorns are skilled at navigating both the material and emotional realms.";
            }
            else if ((BirthDay.Month == 1 && BirthDay.Day >= 20) || (BirthDay.Month == 2 && BirthDay.Day <= 18))
            {
                SignResult[0] = "Aquarius";
                SignResult[1] = "Going against tradition, here comes Aquarius season, a sign ruled by two polar opposite planetary energies: Saturn and Uranus. " +
                    "In many ways, Aquarius awakens the inner rebel in us—but not without a cause—because its incredible intellect " +
                    "asks us to question everything we’ve been told about how things should be. " +
                    "Community-oriented Aquarius season is also our best opportunity of the year to network with like-minded folks and reconsider " +
                    "how these connections relate to our biggest hopes and dreams. This is the sign of the people, " +
                    "the one that most represents the collective state of mind, so altruism is also encouraged during this time.";
                SignResult[2] = "Despite the \"aqua\" in its name, Aquarius is actually the last air sign of the zodiac. Innovative, progressive, and shamelessly revolutionary, " +
                    "Aquarius is represented by the water bearer, the mystical healer who bestows water, or life, upon the land. Accordingly, " +
                    "Aquarius is the most humanitarian astrological sign. At the end of the day, Aquarius is dedicated to making the world a better place.";
            }
            else if ((BirthDay.Month == 2 && BirthDay.Day >= 19) || (BirthDay.Month == 3 && BirthDay.Day <= 20))
            {
                SignResult[0] = "Pisces";
                SignResult[1] = "We close the astrological calendar year by diving into the waters of Pisces. Suddenly, life naturally slows down, " +
                    "and we’re asked to tune into our intuitive, compassionate, and artistic side. Mystical and magical Pisces is the season of divine transcendence, " +
                    "holding the knowledge of all the other 11 signs. This fascinating world is ruled by titans Jupiter and Neptune, " +
                    "whose almost intoxicating essence blurs the line between dreams and reality. For this reason, " +
                    "the month ruled by Pisces is ideal for getting in touch with our feelings and creativity instead of focusing on more tangible things and activities." +
                    " Romance is also highlighted, and we now have cosmic permission to open our hearts.";
                SignResult[2] = "If you looked up the word \"psychic\" in the dictionary, there would definitely be a picture of Pisces next to it. " +
                    "Pisces is the most intuitive, sensitive, and empathetic sign of the entire zodiac — and that’s because it’s the last of the last. As the final sign, " +
                    "Pisces has absorbed every lesson — the joys and the pain, the hopes and the fears — learned by all of the other signs. " +
                    "It's symbolized by two fish swimming in opposite directions, representing the constant division of Pisces' attention between fantasy and reality.";
            }
            else
            {
                SignResult[0] = "Unknown";
                SignResult[1] = "Unknown";
                SignResult[2] = "Unknown";
            }
            return SignResult;
        }

        
        //Provides advice bassed un user's birth year
        public static string LifeCoach(int BirthYear)
        {
            if (BirthYear < 1920)
                return "In all likely hood you're dead... No idea how the deceaced might consult an online service...";
            else if (BirthYear <= 1970)
                return "It's time to take it easy, travel the world, or sit in a comfy chair.";
            else if (BirthYear < 1981)
                return "Put your nose to the grinstone and Work Biatch!";
            else if (BirthYear < 1991)
                return "It's time you moved out of your Mother's Basement and finish a serious degree";
            else if (BirthYear < 2001)
                return "Travel Europe, do drugs, go crazy. It's ok, you're stil young.";
            else if (BirthYear <= DateTime.Now.Year)
                return "You're too young for a Life Coach. Come back when you're potty trained.";
            else
                return "You must be a time traveler. Why are you consulting a Horoscope instead of saving the world from a distopian future?!?";
        }
    }
}