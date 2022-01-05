# CountryFlag.Wpf
![Screenshot](/Flags.Demo/Screenshot.png)

Country flags WPF control library with flags of 255 countries and territories.
## Usage
Install the NuGet package by running the following command in the Package Manager Console,
```
Install-Package CountryFlag.Wpf -Version 1.0.0
```
After installation is complete use as follows,
```xml
<Window xmlns:cf="clr-namespace:CountryFlag.Wpf;assembly=CountryFlag.Wpf">       
    <WrapPanel>
        <cf:CountryFlag CountryCode="BT" />
        <cf:CountryFlag CountryCode="AF" />
        <cf:CountryFlag CountryCode="AO" />
        <cf:CountryFlag CountryCode="BB" />
        ...
    </WrapPanel>    
</Window>
```
