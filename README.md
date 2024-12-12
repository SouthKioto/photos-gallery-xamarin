# Galeria zdjęc - xamarin

## O aplikacji
Prosta aplikacja pobierająca dane z pliku tekstowego i wyświetlająca je w aplikacji mobilnej. W pliku tekstowym znajdują się tylko dane takie jak nazwa, opis data utworzenia oraz id, obrazy znajdują się w folderze **drawable**

## Plik tekstowy
w pliku tekstowym powinny znajdować sie dane takie same jak w [data.txt](https://github.com/SouthKioto/photos-gallery-xamarin/blob/master/App1/App1/data/data.txt)

```txt
1;Laki;Piękne zdjęcie łąki;11-12-2022;
2;Gory;Piękne zdjęcie gór;12-12-2022;
3;Lasy;Piękne zdjęcie lasu;13-12-2022;
```

Aby sprawdzić te dane w emulatorze należy otworzyć konsolę adb oraz wpisać poniższe komendy

```bash
adb root
adb shell
```

oraz przejść pod lokalizację
```bash
cd /data/user/0/com.companyname.app1/files/.local/share
```

jeśli chcemy sprawdzić zawartość pliku

```bash
cat photos.txt
```

Wygląd
<img src="https://github.com/SouthKioto/photos-gallery-xamarin/blob/master/App1/App1.Android/Resources/drawable/screenshot.png"/>
