using System;
using System.Collections;

namespace Program {
    public class Lista {

        private int ListSize { get; set; }
        private string[] ListaTotal { get; set; }
        private static int Position { get; set; }
        public Lista() {
            ListaTotal = new String[100];
            Position = 0;
        }

        public void Add(string element){
            ListaTotal[Position] = element;
            Position ++;
        }

        public void AddMany(string[] elements) {
            
            foreach(string element in elements) {
                ListaTotal[Position] = element;
                Position ++;
            }

        }
        public void Remove(int position) {
            var oldPosition = Position;
            Position = position;
            ListaTotal[Position] = "";
            Position = oldPosition ++;
        }

        public void RemoveAll() {
            Position = 0;
            foreach(string element in ListaTotal) {
                ListaTotal[Position] = "";
                Position++;
            }
            Position = 0;
        }


        public override string ToString() {
            string returnString = "";
            foreach (string element in ListaTotal) {
                    if (!String.IsNullOrEmpty(element)) {
                        returnString += element + ",";
                    }
                }
            return returnString;
        }
    }
}