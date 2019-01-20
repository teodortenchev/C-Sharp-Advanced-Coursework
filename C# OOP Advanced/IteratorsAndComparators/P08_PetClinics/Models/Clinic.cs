using System;
using System.Linq;
using System.Collections.Generic;

namespace P08_PetClinics.Models
{
    public class Clinic
    {
        public string Name { get; set; }

        private int roomCount;

        private int petCounter;

        private Pet[] rooms;

        public Clinic(string name, int roomCount)
        {
            Name = name;
            RoomCount = roomCount;
            rooms = new Pet[roomCount];
            petCounter = 0;

        }

        public int RoomCount
        {
            get { return roomCount; }
            private set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }

                roomCount = value;
            }
        }

        public IReadOnlyCollection<Pet> Rooms => Array.AsReadOnly(rooms);

        public bool HasEmptyRooms => this.Rooms.Any(r => r == null);

        public string GetRoomContents(int roomNumber) => rooms[roomNumber] == null ? "Room empty" : rooms[roomNumber].ToString();

        public bool AdmitPet(Pet pet)
        {
            if (!HasEmptyRooms)
            {
                return false;

            }

            if (rooms[RoomCount / 2] == null)
            {
                rooms[RoomCount / 2] = pet;
                petCounter++;
            }
            else
            {
                int roomIndex = FindEmptyRoom();
                rooms[roomIndex] = pet;
                petCounter++;
            }

            return true;
        }

        public bool ReleasePet()
        {
            if(petCounter > 0)
            {
                if (rooms[RoomCount / 2] != null)
                {
                    rooms[RoomCount / 2] = null;
                    petCounter--;
                    return true;
                }

                else
                {
                    for (int i = RoomCount / 2; i < RoomCount; i++)
                    {
                        if (rooms[i] != null)
                        {
                            rooms[i] = null;
                            petCounter--;
                            return true;
                        }
                    }

                    for (int i = 0; i < RoomCount / 2; i++)
                    {
                        if (rooms[i] != null)
                        {
                            rooms[i] = null;
                            petCounter--;
                            return true;
                        }
                    }

                    
                }
            }

            return false;
        }

        private int FindEmptyRoom()
        {
            if (petCounter % 2 == 0)
            {
                for (int i = RoomCount / 2; i < RoomCount; i++)
                {
                    if (rooms[i] == null)
                    {
                        return i;
                    }
                }
            }
            else
            {
                for (int i = RoomCount / 2; i >= 0; i--)
                {
                    if (rooms[i] == null)
                    {
                        return i;
                    }
                }
            }

            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string[] clinicRepresentation = new string[roomCount];
            clinicRepresentation = Rooms
                .Select(p => p == null ? "Room empty" : p.ToString())
                .ToArray();
            string result = string.Join(Environment.NewLine, clinicRepresentation);

            return result;
        }


    }
}
