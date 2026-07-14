# Repository Audit

## Scope

This audit records the repository areas verified during the Product OS cleanup and the decisions made to create a coherent operating model.

Audit date: 2026-07-14  
Owner: Product Director  
Reviewer: Technical Writer

## Verified top-level model

| Path | Decision | Purpose |
|---|---|---|
| `projects/` | Keep and use as portfolio index | Shows initiatives, status, dependencies and current decisions |
| `apps/` | Keep | Customer-facing implementations and proofs of concept |
| `platform/` | Keep | Shared internal technical foundations |
| `10 Knowledge/` | Keep | Reusable vendor and CRM/domain knowledge |
| `docs/` | Keep | Governance, strategy, process, ownership and standards |
| `Agents/` | Keep | Specialist AI role instructions |
| `README.md` | Keep and maintain as front door | Navigation and repository model |

## Verified projects

### CRM Usage Analytics

Verified assets:

- `projects/README.md` portfolio entry
- `apps/crm-usage-analytics-poc/` implementation
- `apps/crm-usage-analytics-poc/BUSINESS-CASE.md`
- `10 Knowledge/crm/` reusable CRM context
- `10 Knowledge/Vendors/SuperOffice/` platform dependency

Decision: keep the implementation and business case together under the application. Use the project index for status and links.

### Integration SDK

Verified assets:

- `projects/README.md` portfolio entry
- `platform/integration-sdk/` foundation
- `docs/strategy/integration-app-suite.md`
- vendor knowledge under `10 Knowledge/Vendors/`

Decision: keep the SDK under `platform/` because it is internal shared infrastructure, not a customer-facing product.

## Duplicate and placeholder cleanup

The following legacy vendor folders were merged into canonical vendor knowledge bases and removed:

- `10 Knowledge/SuperOffice/`
- `10 Knowledge/Creditsafe/`
- `10 Knowledge/Roaring/`

Canonical locations:

- `10 Knowledge/Vendors/SuperOffice/`
- `10 Knowledge/Vendors/Creditsafe/`
- `10 Knowledge/Vendors/Roaring/`

Unique legacy links were preserved in the relevant `10-REFERENCES.md` files.

The empty `10 Knowledge/ai/` placeholder was removed. Agent behavior belongs under `Agents/`; reusable AI knowledge should be added only when maintained content actually exists.

The empty `10 Knowledge/crm/` placeholder was converted into a maintained CRM knowledge index.

## Navigation fixes

The following navigation documents now define their folder purpose and link to related areas:

- root `README.md`
- `projects/README.md`
- `apps/README.md`
- `platform/README.md`
- `10 Knowledge/README.md`
- `10 Knowledge/Vendors/README.md`
- `Agents/README.md`
- `docs/README.md`

## Current placement rules

| Content | Canonical location |
|---|---|
| Initiative status and decision | `projects/` |
| Customer-facing product or POC | `apps/` |
| Shared internal technical component | `platform/` |
| Reusable vendor or domain knowledge | `10 Knowledge/` |
| Governance, process and cross-product strategy | `docs/` |
| AI specialist role instruction | `Agents/` |

## Items intentionally not created

The repository does not create empty top-level folders for inboxes, ideas, discovery, customers, templates, assets or archives. Those concepts may be represented inside existing folders or added later only when real maintained content requires a separate boundary.

Examples:

- early opportunities can be recorded as draft entries in `projects/` or GitHub issues
- discovery outputs belong with the relevant project or under `docs/` when they define a reusable process
- templates belong under `docs/templates/` only when the first maintained template is introduced
- archived material should remain in Git history unless a navigable archive becomes necessary

## Remaining maintenance checks

The Product Director should periodically verify:

1. every active initiative appears in `projects/README.md`
2. every application and platform component is linked from the portfolio
3. vendor knowledge exists in one location only
4. README links remain valid after moves
5. empty placeholders are removed
6. reusable learning is promoted from projects into Knowledge without copying confidential or supplier-restricted material

## Conclusion

The repository should be managed as six cooperating areas rather than as a large numbered folder hierarchy:

```text
projects → status
apps → customer products
platform → shared engineering
10 Knowledge → reusable knowledge
docs → governance and process
Agents → specialist roles
```

This model reflects the work that actually exists and can expand without introducing speculative folder structures.