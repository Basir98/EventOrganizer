using System;
using System.Collections.Generic;
using System.Text;

namespace EventOrganizer
{
    public class EventManager
    {
        private double costPerPerson;
        private double feePerPerson;
        private ParticipantManager participantManager;
        private string title;

        public double CostPerPerson
        {
            get { return costPerPerson; }
            set { this.costPerPerson = value; }
        }

        public double FeePerPerson
        {
            get { return feePerPerson; }
            set { this.feePerPerson = value; }
        }

        public ParticipantManager Participants
        {
            get { return participantManager; }
        }

        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }

        public EventManager(ParticipantManager participantManager)
        {
            this.participantManager = participantManager;
        }

        public EventManager()
        {
            participantManager = new ParticipantManager();
        }

        /*
         * This method returns the number of participants
         */
        public int numberOfParticipants()
        {
            return participantManager.Count;
        }

        /*
         * This method calculates the total cost
         */
        public double CalcTotalCost()
        {
            return participantManager.Count * CostPerPerson;
        }

        /*
         * This method calculates the total fees
         */
        public double CalcTotalFees()
        {
            return participantManager.Count * FeePerPerson;
        }
    }
}
