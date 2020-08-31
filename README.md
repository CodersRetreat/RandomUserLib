<a href="http://www.robertwildgoose.co.uk"><img src="GitAssets/bannerTop.png" title="RobertWildgoose" alt="RobertWildgoose"></a>

# Random User Generator Library For C#

> This library generates valid content for users, in order to produce testable data for C# software and Xamarin Applications.

[![Logo](GitAssets/logo.png)]()

- Included in the repo is a test project that acts as a demo to show how this code works.


## Table of Contents (Optional)

- [Installation](#installation)
- [FAQ](#faq)
- [License](#license)

![Random User Library](https://github.com/RobertWildgoose/Random-User-Library-CSharp/workflows/Random%20User%20Library/badge.svg)
---

## Installation

- Simply pull this repo down and add the project into your projects solution.
- Once included their are several calls you can make  which are shown below.

## FAQ

- **How do I get a single user?**
```c#
var SingleUser = UserGeneratorService.GetSingleUser().results.ElementAtOrDefault(0);
```
- **How do I get a certain amount of users?**
```c#
var MultipleUsers = UserGeneratorService.GetMultipleUsers(10).results;
```

- **How do I get a previous user back again?**
Holding onto the seed attribute within a Persona will provide you a way to get a previously gotten persona.
```c#
var MultipleUsers = UserGeneratorService.GetSpecificUser(User.seed).results;
```

- **How do I get a User from a specific Demographic?**

This User Will Return As Being From Spain
```c#
var SpanishUser = UserGeneratorService.GetSingleUserSpecificNationality(Nationality.Spain).results.ElementAtOrDefault(0);
```
- **How do I get a Set Of 10 Users from a specific Demographic?**
The Returned Users Will Return As Being From Spain
```c#
var MultipleSpanishUser = UserGeneratorService.GetMultiUsersSpecificNationality(Nationality.Spain,10).results;
```

---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright 2018 © <a href="http://www.robertwildgoose.co.uk" target="_blank">Robert Wildgoose</a>.
