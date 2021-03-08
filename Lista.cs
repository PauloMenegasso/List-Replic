using System;
using System.Collections;

namespace Program {
    public class Lista {
        private int ListSize { get; set; }
        private string[] ListaTotal { get; set; }
        private static int Position { get; set; }
        public Lista() {
            ListaTotal = new String[5];
            Position = 0;
        }

        public void Add(string element){
            ListaTotal[Position] = element;
            Position ++;
			VerifySize(Position);
        }

        public void AddMany(string[] elements) {
            
            foreach(string element in elements) {
				Add(element);
            }
        }

        public void Remove(int position) {
			string[] NovaLista = new string[ListaTotal.Length];
			for (int i = 0; i < position; i++) {
				NovaLista[i] = ListaTotal[i];
			}
			for (int i = position; i < ListaTotal.Length -1; i++) {
				NovaLista[i] = ListaTotal[i+1];
			}
			ListaTotal = NovaLista;
		}

		public void Where() {}

        public void RemoveMany(int[] itensToRemove) {
			foreach (int item in itensToRemove) {
				Remove(item);

				for (int i = 0; i < itensToRemove.Length; i++){
					itensToRemove[i]--;
				}
			}
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

		public void VerifySize(int Position) {
			if (Position == ListaTotal.Length - 1) {
				string[] NovaLista = new string[2*ListaTotal.Length];
				for (int i = 0; i != ListaTotal.Length; i++){
					//ListaTotal.CopyTo(NovaLista, i);
					NovaLista[i] = ListaTotal[i];
				}
				ListaTotal = NovaLista;
			}
		}
    }
}