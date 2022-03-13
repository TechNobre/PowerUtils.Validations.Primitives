# PowerUtils.Validations.Primitives
Provides additional constants for libraries based on validations

![Tests](https://github.com/TechNobre/PowerUtils.Validations.Primitives/actions/workflows/test-project.yml/badge.svg)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Validations.Primitives&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Validations.Primitives)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Validations.Primitives&metric=coverage)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Validations.Primitives)

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.Validations.Primitives.svg)](https://www.nuget.org/packages/PowerUtils.Validations.Primitives)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.Validations.Primitives.svg)](https://www.nuget.org/packages/PowerUtils.Validations.Primitives)
[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.Validations.Primitives.svg)](https://github.com/TechNobre/PowerUtils.Validations.Primitives/blob/main/LICENSE)



## Support to
- .NET 3.1
- .NET 5.0
- .NET 6.0



## Features

- [Constants](#Constants)
- [Helpers](#Helpers)
  - [GetMinFormatted](#Helpers.GetMinFormatted)
  - [GetMaxFormatted](#Helpers.GetMaxFormatted)


## Documentation

### How to use

#### Install NuGet package <a name="Installation"></a>
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
- `MIN_DATETIME_UTCNOW` _(MIN:DATETIME_UTCNOW)_;
- `MAX_DATETIME_UTCNOW` _(MAX:DATETIME_UTCNOW)_;
- `DUPLICATED`;
- `NOT_FOUND`;
- `EXPIRED`;


### Helpers <a name="Helpers"></a>

#### GetMinFormatted <a name="Helpers.GetMinFormatted"></a>

```csharp
// result = "MIN:14"
var result = Helpers.GetMinFormatted(14);
```

#### GetMaxFormatted <a name="Helpers.GetMaxFormatted"></a>

```csharp
// result = "MAX:1244574"
var result = Helpers.GetMaxFormatted(1244574);
```



## :warning: Warning
The constant `ALREADY_EXISTS` will be removed in 2022/09/30.



## Contribution

*Help me to help others*




## LICENSE

[MIT](https://github.com/TechNobre/PowerUtils.Validations.Primitives/blob/main/LICENSE)




## Changelog

[Here](./CHANGELOG.md)
