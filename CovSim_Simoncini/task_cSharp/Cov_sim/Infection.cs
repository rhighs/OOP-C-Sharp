using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cov_sim
{
    public class Infection
    {
        private static readonly int STATUS_PERC = 70;
        private static readonly int FP1_PERC = 30;
        private static readonly int FP2_PERC = 20;
        private static readonly int FP3_PERC = 10;

        /**
         * Run infection algorithm.
         * This specific algorithm doesn't take care of the infector
         * and only looks at the victim.
         */
        public bool apply(Person victim)
        {
            if (victim.isInfected())
            {
                return false;
            }

            int trasm = checkTrasmissibility(victim);
            var rand = new Random();
            int upperbound = 101;
            return rand.Next(upperbound) <= trasm;
        }

        /**
         * Check trasmissibility of a person.
         * Trasmissibility only depends on the mask.
         */
        public int checkTrasmissibility(Person person)
        {
            var protection = person.getMask().getProtection();
            var status = person.getMask().getStatus();
            int perc = 0;

            perc += status == Person.Mask.Status.UP ? 0 : STATUS_PERC;
            switch (protection)
            {
                case Person.Mask.Protection.FP1:
                    perc += FP1_PERC;
                    break;
                case Person.Mask.Protection.FP2:
                    perc += FP2_PERC;
                    break;
                case Person.Mask.Protection.FP3:
                    perc += FP3_PERC;
                    break;
            }

            return perc;
        }

    }
}
