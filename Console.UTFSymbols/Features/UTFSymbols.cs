namespace Console.UTFSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class UTFSymbols
    {
        static UTFSymbols()
        {
            Console.OutputEncoding = Encoding.UTF8;
        }

        private static readonly Dictionary<string, (string,string,string)> _symbols = new()
        {
        // Status
        { nameof(Check), ("U+2714", @"\u2714","\u2714") },
        { nameof(Cross), ("U+2716",@"\u2716", "\u2716") },
        { nameof(Warning), ("U+26A0",@"\u26A0","\u26A0") },
        { nameof(Info), ("U+2139",@"\u2139","\u2139") },
        { nameof(Error), ("U+274C",@"\u274C","\u274C") },
        { nameof(Success), ("U+2705",@"\u2705","\u2705") },

        // Navigation
        { nameof(ArrowRight), ("U+2192",@"\u2192","\u2192") },
        { nameof(ArrowLeft), ("U+2190",@"\u2190","\u2190") },
        { nameof(ArrowUp), ("U+2191",@"\u2191","\u2191") },
        { nameof(ArrowDown), ("U+2193",@"\u2193","\u2193") },
        { nameof(DoubleArrowRight), ("U+21D2",@"\u21D2","\u21D2") },
        { nameof(DoubleArrowLeft), ("U+21D0",@"\u21D0","\u21D0") },

        // Medien
        { nameof(Play), ("U+25B6",@"\u25B6","\u25B6") },
        { nameof(Pause), ("U+u23F8",@"\u23F8","\u23F8") },
        { nameof(Stop), ("U+u25A0",@"\u25A0","\u25A0") },
        { nameof(Record), ("U+23FA",@"\u23FA","\u23FA") },
        { nameof(FastForward), ("U+23E9",@"\u23E9","\u23E9") },
        { nameof(Rewind), ("U+23EA",@"\u23EA","\u23EA") },

        /*
        // Dateien / Ordner
        { nameof(Folder), "\U0001F4C1" },
        { nameof(FolderOpen), "\U0001F4C2" },
        { nameof(File), "\U0001F4C4" },
        { nameof(Trash), "\U0001F5D1" },
        { nameof(Save), "\U0001F4BE" },
        { nameof(Clipboard), "\U0001F4CB" },

        // Werkzeuge
        { nameof(Gear), "\u2699" },
        { nameof(Hammer), "\U0001F528" },
        { nameof(Wrench), "\U0001F527" },
        { nameof(Toolbox), "\U0001F9F0" },

        // Sicherheit
        { nameof(Lock), "\U0001F512" },
        { nameof(Unlock), "\U0001F513" },
        { nameof(Key), "\U0001F511" },
        { nameof(Shield), "\U0001F6E1" },

        // Benutzer / Kommunikation
        { nameof(User), "\U0001F464" },
        { nameof(Users), "\U0001F465" },
        { nameof(Mail), "\u2709" },
        { nameof(Phone), "\u260E" },
        { nameof(Chat), "\U0001F4AC" },

        // Suche / Anzeige
        { nameof(Search), "\U0001F50D" },
        { nameof(Eye), "\U0001F441" },
        { nameof(Hidden), "\U0001F648" },

        // Sterne / Favoriten
        { nameof(Star), "\u2605" },
        { nameof(StarEmpty), "\u2606" },
        { nameof(Heart), "\u2665" },
        { nameof(BrokenHeart), "\U0001F494" },

        // Zeit
        { nameof(Clock), "\U0001F553" },
        { nameof(Hourglass), "\u231B" },
        { nameof(Calendar), "\U0001F4C5" },

        // Entwicklung
        { nameof(Code), "\U0001F4BB" },
        { nameof(Bug), "\U0001F41B" },
        { nameof(Rocket), "\U0001F680" },
        { nameof(Fire), "\U0001F525" },

        // Dokumente
        { nameof(Book), "\U0001F4D6" },
        { nameof(Books), "\U0001F4DA" },
        { nameof(Pencil), "\u270E" },
        { nameof(Scissors), "\u2702" },

        // Wetter
        { nameof(Sun), "\u2600" },
        { nameof(Cloud), "\u2601" },
        { nameof(Umbrella), "\u2602" },
        { nameof(Snowman), "\u2603" },

        // Sonstiges
        { nameof(Home), "\u2302" },
        { nameof(Music), "\u266B" },
        { nameof(Smiley), "\u263A" },
        { nameof(LightBulb), "\U0001F4A1" },
        { nameof(Flag), "\U0001F6A9" },
        { nameof(Pin), "\U0001F4CC" },
        */
    };

        public static (string,string,string) Get(string name)
        {
            return _symbols.TryGetValue(name, out (string,string,string) symbol) ? symbol : ("?","?","?");
        }

        public static IReadOnlyDictionary<string, (string,string,string)> GetAll => _symbols;

        // Status
        public static (string,string,string) Check => _symbols[nameof(Check)];
        public static (string, string,string) Cross => _symbols[nameof(Cross)];
        public static (string, string,string) Warning => _symbols[nameof(Warning)];
        public static (string, string,string) Info => _symbols[nameof(Info)];
        public static (string, string,string) Error => _symbols[nameof(Error)];
        public static (string, string,string) Success => _symbols[nameof(Success)];

        // Navigation
        public static (string, string,string) ArrowRight => _symbols[nameof(ArrowRight)];
        public static (string, string,string) ArrowLeft => _symbols[nameof(ArrowLeft)];
        public static (string, string,string) ArrowUp => _symbols[nameof(ArrowUp)];
        public static (string, string,string) ArrowDown => _symbols[nameof(ArrowDown)];
        public static (string, string,string) DoubleArrowRight => _symbols[nameof(DoubleArrowRight)];
        public static (string, string,string) DoubleArrowLeft => _symbols[nameof(DoubleArrowLeft)];

        // Medien
        public static (string, string, string) Play => _symbols[nameof(Play)];
        public static (string, string, string) Pause => _symbols[nameof(Pause)];
        public static (string, string, string) Stop => _symbols[nameof(Stop)];
        public static (string, string, string) Record => _symbols[nameof(Record)];
        public static (string, string, string) FastForward => _symbols[nameof(FastForward)];
        public static (string, string, string) Rewind => _symbols[nameof(Rewind)];

        /*
        // Dateien
        public static string Folder => _symbols[nameof(Folder)];
        public static string FolderOpen => _symbols[nameof(FolderOpen)];
        public static string File => _symbols[nameof(File)];
        public static string Trash => _symbols[nameof(Trash)];
        public static string Save => _symbols[nameof(Save)];
        public static string Clipboard => _symbols[nameof(Clipboard)];

        // Werkzeuge
        public static string Gear => _symbols[nameof(Gear)];
        public static string Hammer => _symbols[nameof(Hammer)];
        public static string Wrench => _symbols[nameof(Wrench)];
        public static string Toolbox => _symbols[nameof(Toolbox)];

        // Sicherheit
        public static string Lock => _symbols[nameof(Lock)];
        public static string Unlock => _symbols[nameof(Unlock)];
        public static string Key => _symbols[nameof(Key)];
        public static string Shield => _symbols[nameof(Shield)];

        // Benutzer
        public static string User => _symbols[nameof(User)];
        public static string Users => _symbols[nameof(Users)];
        public static string Mail => _symbols[nameof(Mail)];
        public static string Phone => _symbols[nameof(Phone)];
        public static string Chat => _symbols[nameof(Chat)];

        // Suche
        public static string Search => _symbols[nameof(Search)];
        public static string Eye => _symbols[nameof(Eye)];
        public static string Hidden => _symbols[nameof(Hidden)];

        // Favoriten
        public static string Star => _symbols[nameof(Star)];
        public static string StarEmpty => _symbols[nameof(StarEmpty)];
        public static string Heart => _symbols[nameof(Heart)];
        public static string BrokenHeart => _symbols[nameof(BrokenHeart)];

        // Zeit
        public static string Clock => _symbols[nameof(Clock)];
        public static string Hourglass => _symbols[nameof(Hourglass)];
        public static string Calendar => _symbols[nameof(Calendar)];

        // Entwicklung
        public static string Code => _symbols[nameof(Code)];
        public static string Bug => _symbols[nameof(Bug)];
        public static string Rocket => _symbols[nameof(Rocket)];
        public static string Fire => _symbols[nameof(Fire)];

        // Dokumente
        public static string Book => _symbols[nameof(Book)];
        public static string Books => _symbols[nameof(Books)];
        public static string Pencil => _symbols[nameof(Pencil)];
        public static string Scissors => _symbols[nameof(Scissors)];

        // Wetter
        public static string Sun => _symbols[nameof(Sun)];
        public static string Cloud => _symbols[nameof(Cloud)];
        public static string Umbrella => _symbols[nameof(Umbrella)];
        public static string Snowman => _symbols[nameof(Snowman)];

        // Sonstiges
        public static string Home => _symbols[nameof(Home)];
        public static string Music => _symbols[nameof(Music)];
        public static string Smiley => _symbols[nameof(Smiley)];
        public static string LightBulb => _symbols[nameof(LightBulb)];
        public static string Flag => _symbols[nameof(Flag)];
        public static string Pin => _symbols[nameof(Pin)];
        */
    }
}
