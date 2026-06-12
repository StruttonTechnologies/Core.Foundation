# StruttonTechnologies.Core.Foundation

The foundational building blocks of the Strutton Technologies ecosystem.

## Overview

`StruttonTechnologies.Core.Foundation` contains the core contracts, domain models, DTOs, messages, and abstractions that define the capabilities shared across the Strutton Technologies platform.

This solution serves as the architectural foundation upon which higher-level solutions such as Identity, Implementations, External, and application-specific services are built.

The projects contained within this solution are intentionally implementation-agnostic and focus on defining what the system is rather than how it operates.

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

Projects within this solution should contain minimal business logic and avoid implementation-specific dependencies whenever possible.

---

## Solution Structure

```text
Core.Foundation
│
├── Domains
│   ├── StruttonTechnologies.Core.Domain
│   └── StruttonTechnologies.Core.Identity.Domain
│
├── Dtos
│   ├── StruttonTechnologies.Core.Dtos
│   ├── StruttonTechnologies.Core.Coordinator.Dtos
│   └── StruttonTechnologies.Core.Identity.Dtos
│
├── Interfaces
│   ├── StruttonTechnologies.Core.EF.Contracts
│   ├── StruttonTechnologies.Core.Repositories.Contracts
│   ├── StruttonTechnologies.Core.Orchestration.Contracts
│   ├── StruttonTechnologies.Core.Identity.Domain.Contracts
│   ├── StruttonTechnologies.Core.Identity.Orchestration.Contracts
│
└── Messages
    ├── StruttonTechnologies.Core.Coordinator.Contracts
    └── StruttonTechnologies.Core.Identity.Coordinator.Contracts
```

---

## Architectural Position

```text
Core.ToolKits
    ↓
Core.Foundation
    ↓
Core.Identity
    ↓
Core.Implementations
    ↓
Core.External

Core.TestingToolKit
```

Foundation acts as the shared dependency layer between reusable toolkits and higher-level implementations.

---

## Design Principles

### Dependency Direction

Projects within Foundation may depend on:

- StruttonTechnologies.Core.ToolKit packages
- Other Foundation projects

Projects within Foundation should not depend on:

- Core.Identity implementations
- Core.Implementations projects
- Core.External projects
- Application-specific solutions

### Separation of Concerns

Foundation defines:

- Contracts
- Models
- Messages
- Abstractions

Foundation does not implement:

- Business workflows
- Persistence logic
- API endpoints
- User interfaces
- Infrastructure services

### Package Boundaries

Each project is packaged independently to allow consumers to reference only the components required by their application.

Examples include:

- Repository contracts without Entity Framework implementations
- Coordinator message contracts without handlers
- Domain models without persistence concerns

---

## Build Order

Foundation is built after ToolKits and before all higher-level solutions.

```text
1. Core.ToolKits
2. Core.Foundation
3. Core.Identity
4. Core.Implementations
5. Core.External
6. Core.TestingToolKit
```

---

## License

Copyright © Strutton Technologies.  
All rights reserved.
