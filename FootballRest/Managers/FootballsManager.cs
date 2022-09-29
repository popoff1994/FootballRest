using System.Collections.Generic;

namespace FootballRest.Managers
{
    public class FootballsManager
    {
        private static int _nextId = 1;
        private static readonly List<FootballPlayerLibrary.Class1> Data = new List<FootballPlayerLibrary.Class1>
        {
            new FootballPlayerLibrary.Class1{Id = _nextId++, Age = 53, Name = "Zvonimir", ShirtNumber = 2 },
            new FootballPlayerLibrary.Class1{Id = _nextId++, Age = 40, Name = "Zlatan", ShirtNumber = 3 },
            new FootballPlayerLibrary.Class1{Id = _nextId++, Age = 50, Name = "Zidane", ShirtNumber = 4 },
            new FootballPlayerLibrary.Class1{Id = _nextId++, Age = 50, Name = "Peter", ShirtNumber = 5 },
           
        };

        public List<FootballPlayerLibrary.Class1> GetAll()
        {
            return new List<FootballPlayerLibrary.Class1>(Data);
        }

        public FootballPlayerLibrary.Class1 GetById(int id)
        {
            return Data.Find(ipa => ipa.Id == id);
        }

        public FootballPlayerLibrary.Class1 Add(FootballPlayerLibrary.Class1 newIPA)
        {
            newIPA.Id = _nextId++;
            Data.Add(newIPA);
            return newIPA;
        }

        public FootballPlayerLibrary.Class1 Delete(int id)
        {
            FootballPlayerLibrary.Class1 ipa = Data.Find(ipa1 => ipa1.Id == id);
            if (ipa == null) return null;
            Data.Remove(ipa);
            return ipa;
        }
        public FootballPlayerLibrary.Class1 Update(int id, FootballPlayerLibrary.Class1 updates)
        {
            FootballPlayerLibrary.Class1 ipa = Data.Find(ipa1 => ipa1.Id == id);
            if (ipa == null) return null;
            ipa.Age = updates.Age;
            ipa.Name = updates.Name;
            ipa.ShirtNumber = updates.ShirtNumber;
            return ipa;
        }
    }
}
