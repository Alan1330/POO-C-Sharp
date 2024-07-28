namespace Geral {
    internal class Calculator {

        // Método de somar varios paramentros dentro de um vetor
        public static int Some(params int[] num) {
            int somas = 0;
            for(int i = 0; i < num.Length; i++) {
                somas += num[i];
            }
            return somas;
        }

        //Métodos
        public static void Triple(int origin, out int result) {
            result = origin * 3;
        }

        
    }
}
