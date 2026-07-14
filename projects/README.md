# Projects

This folder is the portfolio index for active and completed initiatives. It does not duplicate source code or full product documentation. Each project links to the place where its implementation, business case, strategy, platform dependencies and reusable knowledge live.

## CRM Usage Analytics

**Type:** Customer-facing product experiment  
**Status:** Proof of concept and business-case validation  
**Purpose:** Measure SuperOffice CRM adoption by user and team.

### Project assets

- [Implementation and run instructions](../apps/crm-usage-analytics-poc/README.md)
- [Business case](../apps/crm-usage-analytics-poc/BUSINESS-CASE.md)
- [Reusable CRM knowledge](../10%20Knowledge/crm/README.md)
- [SuperOffice platform knowledge](../10%20Knowledge/Vendors/SuperOffice/README.md)

### Dependencies

- SuperOffice tenant data and available usage signals
- SuperOffice application authorization and permissions
- CRM-domain definitions for adoption and activity

### Current decision

Continue with technical API validation, customer discovery and paid-pilot validation before committing to a full commercial build.

---

## Integration SDK

**Type:** Internal platform project  
**Status:** Foundation defined  
**Purpose:** Provide reusable SuperOffice infrastructure for supplier-specific applications without combining supplier data or commercial products.

### Project assets

- [Platform foundation](../platform/integration-sdk/README.md)
- [Supplier-specific application strategy](../docs/strategy/integration-app-suite.md)
- [Vendor knowledge index](../10%20Knowledge/Vendors/README.md)
- [SuperOffice knowledge base](../10%20Knowledge/Vendors/SuperOffice/README.md)
- [Creditsafe knowledge base](../10%20Knowledge/Vendors/Creditsafe/README.md)
- [Roaring knowledge base](../10%20Knowledge/Vendors/Roaring/README.md)

### Dependencies

- SuperOffice authentication, tenant context and entity operations
- separate supplier-specific applications and contracts
- vendor knowledge for each supplier adapter
- shared security, configuration, logging, mapping and background-job conventions

### Current decision

Use real supplier applications to validate reusable components. Keep supplier-specific API clients, contracts, credentials and business logic outside the shared SDK.

## Project rules

1. Customer-facing implementations live under `apps/`.
2. Shared internal foundations live under `platform/`.
3. Reusable reference knowledge lives under `10 Knowledge/`.
4. Governance and strategy live under `docs/`.
5. Every project lists its knowledge and platform dependencies here.
6. This index must be updated whenever a project starts, changes status, is paused or is completed.