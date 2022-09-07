using System;
public class Coin {
    public static float B1000(float money1) {
        float ans = money1 / 1000;
        float change = money1 % 1000;
        return ans ;
    }

    public static float B500(float money1) {
        float a = money1 % 1000;
        float ans = a / 500;
        return ans ;
    }

    public static float B100(float money1) {
        float a = money1 % 1000;
        float b = a % 500;
        float ans = b / 100;
        return ans ;
    }

    public static float B50(float money1) {
        float a = money1 % 1000;
        float b = a % 500;
        float c = b % 100;
        float ans = c / 50;
        return ans ;
    }

    public static float B20(float money1) {
        float a = money1 % 1000;
        float b = a % 500;
        float c = b % 100;
        float d = c % 50;
        float ans = d / 20;
        return ans ;
    }

    public static float B10(float money1) {
        float a = money1 % 1000;
        float b = a % 500;
        float c = b % 100;
        float d = c % 50;
        float e = d % 20;
        float ans = e / 10;
        return ans ;
    }

    public static float B5(float money1) {
        float a = money1 % 1000;
        float b = a % 500;
        float c = b % 100;
        float d = c % 50;
        float e = d % 20;
        float f = e % 10;
        float ans = f / 5;
        return ans ;
    }

    public static float B2(float money1) {
        float a = money1 % 1000;
        float b = a % 500;
        float c = b % 100;
        float d = c % 50;
        float e = d % 20;
        float f = e % 10;
        float g = f % 5;
        float ans = g / 2;
        return ans ;
    }

    public static float B1(float money1) {
        float a = money1 % 1000;
        float b = a % 500;
        float c = b % 100;
        float d = c % 50;
        float e = d % 20;
        float f = e % 10;
        float g = f % 5;
        float h = g % 2;
        float ans = h / 1;
        return ans ;
    }

    public static float B_50(float money1) {
        float a = money1 % 1000;
        float b = a % 500;
        float c = b % 100;
        float d = c % 50;
        float e = d % 20;
        float f = e % 10;
        float g = f % 5;
        float h = g % 2;
        float i = h % 1;
        float ans = i / (0.5f);
        return ans ;
    }

    public static float B_25(float money1) {
        float a = money1 % 1000;
        float b = a % 500;
        float c = b % 100;
        float d = c % 50;
        float e = d % 20;
        float f = e % 10;
        float g = f % 5;
        float h = g % 2;
        float i = h % 1;
        float j = i % (0.5f);
        float ans = j / (0.25f);
        return ans ;
    }
}