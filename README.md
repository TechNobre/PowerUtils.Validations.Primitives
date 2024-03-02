# PowerUtils.Validations.Primitives

# :warning: DEPRECATED

This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project.

![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.Validations.Primitives/main/assets/logo/logo_128x128.png)

***Provides additional constants for libraries based on validations***

[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.Validations.Primitives.svg)](https://github.com/TechNobre/PowerUtils.Validations.Primitives/blob/main/LICENSE)


- [Support to ](#support-to-)
- [How to use ](#how-to-use-)
  - [Install NuGet package ](#install-nuget-package-)
  - [Constants ](#constants-)
  - [Helpers ](#helpers-)
    - [GetMinFormatted ](#getminformatted-)
    - [GetMaxFormatted ](#getmaxformatted-)
- [:warning: Warning](#warning-warning)
- [Contribution](#contribution)



## Support to <a name="support-to"></a>
- .NET 6.0
- .NET 5.0
- .NET 3.1



## How to use <a name="how-to-use"></a>

### Install NuGet package <a name="Installation"></a>
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.Validations.Primitives

**Nuget**
```bash
Install-Package PowerUtils.Validations.Primitives
```

**.NET CLI**
```
dotnet add package PowerUtils.Validations.Primitives
```



### Constants <a name="Constants"></a>

- `REQUIRED`;
- `INVALID`;
- `UNAUTHORIZED`;
- `FORBIDDEN`;
- `MIN`;
- `MAX`;
- `MIN_ZERO` _(MIN:0)_;
- `MAX_ZERO` _(MAX:0)_;
- `MIN_DATETIME_UTCNOW` _(MIN:DATETIME_UTCNOW)_;
- `MAX_DATETIME_UTCNOW` _(MAX:DATETIME_UTCNOW)_;
- `MIN_LATITUDE` _(MIN:-90)_;
- `MAX_LATITUDE` _(MAX:90)_;
- `MIN_LONGITUDE` _(MIN:-180)_;
- `MAX_LONGITUDE` _(MAX:180)_;
- `DUPLICATED`;
- `NOT_FOUND`;
- `EXPIRED`;


### Helpers <a name="Helpers"></a>

#### GetMinFormatted <a name="Helpers.GetMinFormatted"></a>
Supports the types `string`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal`, `DateTime`

```csharp
// result = "MIN:14"
var result = Helpers.GetMinFormatted(14);
```

#### GetMaxFormatted <a name="Helpers.GetMaxFormatted"></a>
Supports the types `string`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal`, `DateTime`

```csharp
// result = "MAX:1244574"
var result = Helpers.GetMaxFormatted(1244574);
```



## :warning: Warning
The constant `ALREADY_EXISTS` will be removed in 2022/09/30.



## Contribution<a name="contribution"></a>

If you have any questions, comments, or suggestions, please open an [issue](https://github.com/TechNobre/PowerUtils.Validations.Primitives/issues/new/choose) or create a [pull request](https://github.com/TechNobre/PowerUtils.Validations.Primitives/compare)
