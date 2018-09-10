using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            // Checking if arguments passed are null
            if(original==null){
                throw(new ArgumentNullException("original"));
            }
            if(current == null){
                throw(new ArgumentNullException("current"));
            }
            // Checking if the arguments have equal length. Hamming distance
            // can only be checked with strings of equal length
            if(original.Length != current.Length){
                throw(new ArgumentException("Hamming Distance can only be calculated over strings of equal length"));
            }
            // initialising distance
            int hammingDistance = 0;
            // if ith characters of both strings are different then we 
            // increment hamming distance
            for(int i = 0;i < original.Length; i++){
                if(original[i] != current[i]){
                    hammingDistance++;
                }
            }
            return hammingDistance;
        }
    }

}

