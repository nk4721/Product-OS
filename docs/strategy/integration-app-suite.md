# Supplier-Specific Integration App Strategy

## Decision

Product OS will not pursue a generic customer intelligence platform.

Instead, we will build a portfolio of separate supplier-specific applications for SuperOffice. Each application will be licensed, configured, marketed and maintained independently according to the customer's agreement with the relevant data supplier.

The first reference application is **Creditsafe for SuperOffice**.

---

# Product model

## Separate commercial applications

Each data supplier gets its own application.

Examples:

- Creditsafe for SuperOffice
- DataBlocks for SuperOffice
- Roaring for SuperOffice
- Future supplier-specific applications

Each application must:

- use only the selected supplier's APIs and licensed data
- follow that supplier's contractual and storage rules
- have its own product scope and roadmap
- have separate tenant configuration and credentials
- have separate commercial packaging and pricing
- expose only functionality covered by the customer's supplier agreement
- remain deployable and maintainable without requiring another supplier's application

Customers must never be given the impression that data is interchangeable between suppliers.

---

# Shared internal foundation

The applications may share an internal development framework called **Integration SDK**.

The Integration SDK is not a customer-facing product. It is a reusable technical foundation that reduces duplicated development while keeping every commercial application independent.

## Integration SDK responsibilities

- SuperOffice authentication and tenant context
- SuperOffice REST adapter
- web panel hosting conventions
- common UI components
- configuration framework
- encrypted secret storage
- role and permission checks
- audit logging
- correlation IDs and operational logging
- background job conventions
- document handling
- field mapping framework
- localization
- caching
- health checks
- error handling
- telemetry
- test utilities

## The SDK must not contain

- supplier-specific endpoints
- supplier-specific report models
- assumptions that fields mean the same thing across suppliers
- shared customer credentials
- cross-supplier data matching
- a unified commercial data model exposed to customers

---

# Repository structure

```text
Product-OS/
├── platform/
│   └── integration-sdk/
│       ├── src/
│       │   ├── Authentication/
│       │   ├── SuperOffice/
│       │   ├── Configuration/
│       │   ├── Security/
│       │   ├── Logging/
│       │   ├── BackgroundJobs/
│       │   ├── Documents/
│       │   ├── FieldMapping/
│       │   ├── Localization/
│       │   └── WebPanels/
│       ├── tests/
│       └── README.md
│
└── apps/
    ├── creditsafe-for-superoffice/
    │   ├── backend/
    │   ├── frontend/
    │   ├── docs/
    │   ├── tests/
    │   └── PROJECT.md
    ├── datablocks-for-superoffice/
    └── roaring-for-superoffice/
```

---

# Architectural principles

## 1. Supplier isolation

Every application has its own supplier adapter, data contracts, credentials, configuration and persistence rules.

## 2. Contract-driven functionality

The available features are determined by the customer's agreement with the supplier.

The application must support feature flags and entitlement checks for functions such as:

- company search
- credit reports
- monitoring
- board members
- signatories
- beneficial owners
- person search
- international data
- prospecting

## 3. No silent substitution

If a function is unavailable in the customer's supplier agreement, the application must clearly state that it is unavailable or available as an additional supplier service. It must not substitute data from another supplier.

## 4. Separate domain models

Each supplier adapter maps its API responses into an application-specific domain model. Shared infrastructure types may be reused, but business meanings must not be forced into a universal cross-supplier schema.

## 5. Data minimization

Only data needed for the configured SuperOffice workflow should be stored. Report content, personal data and monitoring events must follow supplier terms, GDPR requirements and tenant-specific retention rules.

## 6. Replaceable adapters

SuperOffice integration, supplier integration and presentation layers must be separated so changes to an external API do not require redesigning the entire application.

---

# Creditsafe reference application

Creditsafe for SuperOffice will validate the Integration SDK.

Its first product scope includes:

- company search
- company preview
- company matching
- import to SuperOffice
- update of existing companies
- company information
- credit checks
- credit reports
- monitoring
- board members
- signatories
- beneficial owners where licensed and available
- contacts and role information where licensed and available
- field mapping
- audit history

Creditsafe-specific logic belongs inside the Creditsafe application and not in the shared SDK.

---

# Product governance

Every new supplier application must have:

- a separate `PROJECT.md`
- documented supplier agreement assumptions
- an API capability matrix
- a data storage and retention assessment
- a field mapping document
- a security and permission model
- its own roadmap and backlog
- its own release notes
- a clear commercial package

Before an Integration SDK component is created, at least two applications should reasonably benefit from it, unless the component is fundamental SuperOffice infrastructure.

---

# Immediate next steps

1. Create the `platform/integration-sdk` skeleton.
2. Move reusable SuperOffice concerns into the SDK design.
3. Keep Creditsafe API logic inside `apps/creditsafe-for-superoffice`.
4. Produce the Creditsafe API capability and entitlement matrix.
5. Define the first MVP backlog for Creditsafe for SuperOffice.
6. Use the Creditsafe application to test which shared components are genuinely reusable.

---

# Success criteria

This strategy is successful when:

- supplier agreements remain clearly separated
- each application can be sold and deployed independently
- a customer only sees functions included in its agreement
- shared infrastructure reduces implementation time
- supplier-specific behavior remains easy to change
- adding a new supplier application does not destabilize existing applications
