# Applications

`apps/` contains customer-facing products, proofs of concept and deployable product implementations.

## Current application

### CRM Usage Analytics POC

Measures SuperOffice CRM adoption by user and team.

- [Project implementation](crm-usage-analytics-poc/README.md)
- [Business case](crm-usage-analytics-poc/BUSINESS-CASE.md)
- [Portfolio entry](../projects/README.md#crm-usage-analytics)
- [Reusable CRM knowledge](../10%20Knowledge/crm/README.md)

## Rules

- Each application owns its product-specific code, documentation, tests and release notes.
- Reusable infrastructure should move to `platform/` only after a genuine shared need is demonstrated.
- Reusable vendor and domain knowledge should be linked from `10 Knowledge/`, not copied into every application.
- Supplier-specific applications must keep credentials, entitlements, contracts and data models separated.
