# Integration SDK

## Purpose

The Integration SDK is the shared internal foundation for supplier-specific SuperOffice applications.

It is not a commercial customer intelligence platform and must not combine or substitute data between suppliers.

## Initial modules

- `Authentication` — SuperOffice tenant and user context
- `SuperOffice` — reusable REST client and entity operations
- `Configuration` — tenant settings and feature entitlements
- `Security` — encrypted credentials, roles and permissions
- `Logging` — audit events, correlation IDs and telemetry
- `BackgroundJobs` — scheduled synchronization and retry conventions
- `Documents` — report and SuperOffice document handling
- `FieldMapping` — configurable mapping to standard and custom fields
- `Localization` — shared language conventions
- `WebPanels` — common hosting and navigation patterns

## Design rules

1. Supplier-specific API clients stay inside their own applications.
2. Supplier report schemas are not added to the SDK.
3. Data access is always tenant-scoped.
4. Secrets are never exposed to the browser.
5. Every write to SuperOffice must be traceable.
6. Shared components require tests and versioned contracts.
7. An app must remain deployable without other supplier apps.

## First consumer

`apps/creditsafe-for-superoffice`

Creditsafe for SuperOffice will be used to validate the first SDK components. Reuse should be extracted carefully rather than creating abstractions before real implementation needs are known.

## First implementation task

Create a minimal .NET solution containing:

- tenant context interface
- SuperOffice API client interface
- encrypted configuration interface
- audit event model
- field mapping contracts
- background job result model
- unit-test project

The first implementation must not include Creditsafe-specific endpoints or models.
