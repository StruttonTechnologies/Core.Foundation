# STSS.Core.Foundation

The dependency-free foundation of the Strutton Technologies engineering ecosystem.

## Overview

`STSS.Core.Foundation` defines the shared contracts, models, messages, rules, and abstractions upon which higher-level capabilities are built.

This solution contains the architectural building blocks that are intended to be reused throughout the Strutton Technologies ecosystem. Projects within Foundation are implementation-agnostic and focus on defining capabilities rather than implementing workflows.

The solution is organized by capability while remaining dependency-free whenever possible. It provides the common language used by higher-level solutions such as Identity, Implementations, Presentation, and application-specific systems.

---

## Purpose

The Foundation solution provides:

- Domain entities and models
- Data transfer objects (DTOs)
- Commands, queries, and message contracts
- Service and repository abstractions
- Identity contracts and domain abstractions
- Entity Framework contracts
- Shared capability definitions
- Universal rule authorities

Projects within this solution should contain minimal business logic and avoid implementation-specific dependencies whenever possible.

---

## Repository Layout

```text
Core.Foundation
¦
+-- src
¦   +-- Domains
¦   +-- Dtos
¦   +-- Interfaces
¦   +-- Messages
¦   +-- Rules
¦
+-- tests
    +-- STSS.Core.Foundation.UnitTests
    +-- STSS.Core.Foundation.FunctionalTests
    +-- STSS.Core.Foundation.IntegrationTests
```

The repository is organized to clearly separate production code from automated tests while maintaining a consistent structure across all Strutton Technologies solutions.

---

## Solution Structure

```text
Core.Foundation
¦
+-- Domains
¦   +-- STSS.Core.Domain
¦   +-- STSS.Core.Identity.Domain
¦
+-- Dtos
¦   +-- STSS.Core.Dtos
¦   +-- STSS.Core.Coordinator.Dtos
¦   +-- STSS.Core.Identity.Dtos
¦
+-- Interfaces
¦   +-- STSS.Core.EF.Contracts
¦   +-- STSS.Core.Repositories.Contracts
¦   +-- STSS.Core.Orchestration.Contracts
¦   +-- STSS.Core.Identity.Domain.Contracts
¦   +-- STSS.Core.Identity.Orchestration.Contracts
¦   +-- STSS.MediatR.Abstracts
¦
+-- Messages
¦   +-- STSS.Core.Coordinator.Contracts
¦   +-- STSS.Core.Identity.Coordinator.Contracts
¦
+-- Rules
    +-- STSS.Core.Rules
```

Each project represents an independently versioned capability that can be consumed through NuGet without exposing unnecessary implementation details.

---

## Foundation Rules

`STSS.Core.Rules` contains dependency-free rule authorities for universally applicable concepts.

Examples include:

- EmailRules
- PhoneNumberRules
- UsZipCodeRules
- UrlRules

Rule classes are the authoritative source for operations associated with a concept, including:

- Validation
- Normalization
- Formatting
- Parsing
- Other dependency-free behavior

Rule classes are intentionally implemented as static classes and may be referenced by any architectural layer without introducing inappropriate coupling.

Rules describe universally true concepts. They do not contain application-specific business logic.

---

## Architectural Position

```text
Core.ToolKits
        ¦
        ?
Core.Foundation
        ¦
        ?
Core.Identity
        ¦
        ?
Core.Implementations
        ¦
        ?
Core.PresentationLayer
        ¦
        ?
Applications
```

Foundation serves as the stable dependency layer between reusable toolkits and higher-level implementations.

---

## Design Principles

### Dependency Direction

Projects within Foundation may depend on:

- .NET Base Class Library
- Strutton Technologies Core ToolKit packages
- Other Foundation projects when appropriate

Projects within Foundation should never depend on:

- Core.Identity implementations
- Core.Implementations projects
- Core.PresentationLayer projects
- Application-specific solutions
- Infrastructure implementations

Foundation must remain implementation-agnostic.

---

### Separation of Concerns

Foundation defines:

- Contracts
- Models
- Messages
- Rules
- Abstractions

Foundation does not implement:

- Business workflows
- Persistence logic
- API endpoints
- User interfaces
- Infrastructure services

---

### Package Boundaries

Each project is packaged independently to allow consumers to reference only the capabilities required by their application.

Examples include:

- Repository contracts without Entity Framework implementations
- Coordinator message contracts without handlers
- Domain models without persistence concerns
- Rule authorities without validation frameworks

---

### Solution vs. Package Organization

The Foundation solution is organized by dependency hierarchy to support development and maintenance.

Projects are organized by capability and packaged independently.

```text
Solution
    ?
Dependency Organization

Project
    ?
Capability

Package
    ?
Reusable Feature

Namespace
    ?
Logical API Surface
```

Consumers reference capabilities rather than architectural layers.

---

## Build Order

Foundation is built after ToolKits and before all higher-level solutions.

```text
1. Core.ToolKits
2. Core.Foundation
3. Core.Identity
4. Core.Implementations
5. Core.PresentationLayer
6. Applications
```

---

## License

Copyright © Strutton Technologies.

All rights reserved.
