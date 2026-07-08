# STSS.Core.Rules

Dependency-free rule authorities for universal concepts.

Rules are lower-level than validators. A rule class owns what is universally true about a concept, while validation frameworks decide how those rules are applied to requests, DTOs, forms, entities, or value objects.

Examples:

```csharp
EmailRules.IsValid(value);
EmailRules.Normalize(value);
EmailRules.GetDomain(value);

PhoneNumberRules.IsValid(value);
PhoneNumberRules.FormatNational(value);

UsZipCodeRules.IsValid(value);
```

Rules must not depend on application, domain, infrastructure, presentation, DTO, or Entity Framework assemblies.
