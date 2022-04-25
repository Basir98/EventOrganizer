using System;
using System.Collections.Generic;
using System.Text;

namespace EventOrganizer
{
    public class ParticipantManager
    {
        private List<Participant> participants;

        public int Count
        {
            get { return participants.Count; }
        }

        public ParticipantManager()
        {
            participants = new List<Participant>();
        }

        /*
         * This method recieves a Participant as parameter and adds this participant to the participants list. 
         */
        public bool AddParticipant(Participant participant)
        {
            participants.Insert(Count, participant);
            return true;
        }

        /*
        public Participant GetParticipantAt(int index)
        {
            return participants[index];
        }

        public string[] GetParticipantInfo()
        {
            Participant user = participants[Count-1];
            string[] userInfo = {user.FirstName, user.LastName, user.Address.ToString() };
            return userInfo;
        }
        */

        /*
         *  This method returns all the participants in the participants list
         */
        public List<Participant> GetAllParticipants()
        {
            return participants;
        }

        /*
         * This method recevies an index as parameter and removes the participant from the list at this index
         */
        public bool DeleteParticipantAt(int index)
        {
            if (index < participants.Count)
            {
                participants.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
