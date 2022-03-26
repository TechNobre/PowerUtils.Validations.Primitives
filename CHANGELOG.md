# Changelog




## [1.1.0] - 2022-03-26
[Full Changelog](https://github.com/TechNobre/PowerUtils.Validations.Primitives/compare/v1.0.0...v1.1.0)


### New Features

- Added new constants `MIN_ZERO` and `MAX_ZERO`;




## [1.0.0] - 2022-03-15

- Kickoff;
- Moved the attributes from [PowerUtils.Validations](https://github.com/TechNobre/PowerUtils.Validations) project to this one so it can be used individually;


### New Features

- Added new constants `DUPLICATED` and `EXPIRED`;
- Added helper `ErrorCodes.GetMinFormatted(int min);`;
- Added helper `ErrorCodes.GetMaxFormatted(int max);`;
- Added helper `ErrorCodes.GetMinFormatted(uint min);`;
- Added helper `ErrorCodes.GetMaxFormatted(uint max);`;
- Added helper `ErrorCodes.GetMinFormatted(ulong min);`;
- Added helper `ErrorCodes.GetMaxFormatted(ulong max);`;
- Added helper `ErrorCodes.GetMinFormatted(float min);`;
- Added helper `ErrorCodes.GetMaxFormatted(float max);`;
- Added helper `ErrorCodes.GetMinFormatted(decimal min);`;
- Added helper `ErrorCodes.GetMaxFormatted(decimal max);`;
- Added helper `ErrorCodes.GetMinFormatted(DateTime min);`;
- Added helper `ErrorCodes.GetMaxFormatted(DateTime max);`;
- Added helper `ErrorCodes.GetMinFormatted<TValue>(TValue min);`;
- Added helper `ErrorCodes.GetMaxFormatted<TValue>(TValue max);`;


### Breaking Changes

- Discontinued the constant `ALREADY_EXISTS`. New constant `DUPLICATED`;