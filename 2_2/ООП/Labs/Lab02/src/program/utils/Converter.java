package program.utils;

public class Converter {
    public static Double toKilograms(Integer grams){
        return grams / 1000.0;
    }

    public static Double toCenters(Integer grams){
        return grams / 100000.0;
    }

    public static Double toTons(Integer grams){
        return grams / 1000000.0;
    }

    public static Double toKilobytes(Integer bytes){
        return bytes / 1024.0;
    }

    public static Double toMegabytes(Integer bytes){
        return bytes / 1048576.0;
    }

    public static Double toGigabytes(Integer bytes){
        return bytes / 1073741824.0;
    }
}
