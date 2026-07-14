# Platform

`platform/` contains reusable internal technical foundations. Platform components are not customer-facing products and should exist only when they reduce duplication across multiple applications or provide fundamental shared infrastructure.

## Current platform project

### Integration SDK

Shared foundation for supplier-specific SuperOffice applications.

- [Integration SDK foundation](integration-sdk/README.md)
- [Portfolio entry](../projects/README.md#integration-sdk)
- [Supplier-specific integration strategy](../docs/strategy/integration-app-suite.md)
- [Vendor knowledge framework](../10%20Knowledge/Vendors/README.md)

## Rules

- Keep supplier-specific API clients and business models inside their application.
- Do not combine supplier data, credentials or commercial entitlements.
- Extract shared components from demonstrated needs rather than speculative abstraction.
- Require tests, versioned contracts, tenant isolation, auditability and secure secret handling.
