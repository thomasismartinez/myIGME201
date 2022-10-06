using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetApp
{
    /// <summary>
    /// Class: Program
    /// Author: Thomas Martinez
    /// Purpose: PE13
    /// Restrictions: None
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Method: Main
        /// Purpose: create list of pets, add new pets it, and do activities with pets
        /// Restrictions: None
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // reference variables
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;
            
            // list of pets
            Pets pets = new Pets();

            // rng
            Random rand = new Random();

            // iterates
            for (int i = 0; i < 50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        // add a dog
                        do
                        {
                            try
                            {
                                Console.Write("You bought a dog!\nDog's Name => ");
                                string name = Console.ReadLine();
                                Console.Write("Age => ");
                                int age = Int32.Parse(Console.ReadLine());
                                Console.Write("License => ");
                                string license = Console.ReadLine();

                                pets.Add(new Dog(license, name, age));
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input");
                                continue;
                            }
                        } while (true);
                    }
                    else
                    {
                        // else add a cat
                        do
                        {
                            try
                            {
                                Console.Write("You bought a cat!\nCat's Name => ");
                                string name = Console.ReadLine();
                                Console.Write("Age => ");
                                int age = Int32.Parse(Console.ReadLine());

                                cat = new Cat();
                                cat.Name = name;
                                cat.age = age;
                                pets.Add(cat);
                                break;
                            }
                            catch {
                                Console.WriteLine("Invalid Input");
                                continue; 
                            }
                        } while (true);
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    Pet randomPet = pets[rand.Next(0, pets.Count)];

                    if (randomPet == null)
                    { continue; }

                    if (randomPet is Cat)
                    {
                        // do random activity
                        ICat ic = (ICat)randomPet;
                        switch (rand.Next(0, 4))
                        {
                            case 0: ic.Eat(); break;
                            case 1: ic.Play(); break;
                            case 2: ic.Scratch(); break;
                            case 3: ic.Purr(); break;
                        }
                    }
                    else
                    {
                        // do random activity
                        IDog id = (IDog)randomPet;
                        switch (rand.Next(0, 4))
                        {
                            case 0: id.Eat(); break;
                            case 1: id.Play(); break;
                            case 2: id.NeedWalk(); break;
                            case 3: id.Bark(); break;
                        }
                    }
                }
            }

        }
    }

    // stores list of pets which can be read and written to
    public class Pets
    {
        public List<Pet> petList = new List<Pet>();

        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        // returns the number of pets
        public int Count
        {
            get { return petList.Count; }
        }

        // adds new pet
        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        // removes pet
        public void Remove(Pet pet)
        {
            petList.Add(pet);
        }

        // removes pet at a specific position
        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
    }

    // parent class for all pets
    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get;
            set;
        }

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

        public Pet() { }
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public interface ICat
    {
        void Eat();
        void Scratch();
        void Play();
        void Purr();
    }

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }

    public class Cat : Pet, ICat
    {
        // instantiate activities

        public override void Eat()
        {
            Console.WriteLine(this.Name + ": Yummy fish!");
        }

        public override void Play()
        {
            Console.WriteLine(this.Name + ": This feather is so much fun!");
        }

        public void Purr()
        {
            Console.WriteLine(this.Name + ": Puurrrr~");
        }

        public void Scratch()
        {
            Console.WriteLine(this.Name + ": Take that couch >:(");
        }

        public override void GotoVet()
        {
            Console.WriteLine(this.Name + ": Sure, I'll take a car ride...");
        }

        public Cat() { }

    }

    public class Dog : Pet, IDog
    {
        public string license;

        // instantiate activities

        public override void Eat()
        {
            Console.WriteLine(this.Name + ": Tasty bone!");
        }

        public override void Play()
        {
            Console.WriteLine(this.Name + ": I love my ball.");
        }

        public void Bark()
        {
            Console.WriteLine(this.Name + ": WOOF");
        }

        public void NeedWalk()
        {
            Console.WriteLine(this.Name + ": WALK! WALK! WALK!");
        }

        public override void GotoVet()
        {
            Console.WriteLine(this.Name + ": But its scary there...");
        }

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense;
            Name = szName;
            age = nAge;
        }
    }
}
