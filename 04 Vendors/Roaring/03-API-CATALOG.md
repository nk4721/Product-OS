---
title: Roaring API Capability Catalog
vendor: Roaring
owner: Solution Architect
reviewer: Product Director
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: API Catalog
domain: Roaring
audience: [Product Director, Discovery Agent, Solution Architect, Backend Developer, Product Marketing]
source_of_truth: [Official Roaring API catalog and product agreements]
related_documents: [01-PLATFORM-OVERVIEW.md, 04-DATA-MODEL.md, 09-KNOWN-LIMITATIONS.md]
---
# API capability catalog

This is a capability map, not an endpoint specification. Confirm current names, schemas, country coverage and entitlements in official documentation.

## Capability groups

### Organization discovery and enrichment

Potential capabilities include organization search, core company information, addresses, status, industry, financial attributes and reports.

### Roles, ownership and authority

Potential capabilities include board or management roles, beneficial ownership, company engagements, signatory rights and signing combinations.

### Person data

Potential capabilities include person lookup, identity/address validation or company engagements, subject to country, purpose, licence and privacy controls.

### Compliance and risk

Potential capabilities include PEP and sanctions screening, business restrictions, risk indicators and KYC-related data.

### Monitoring and change events

Potential capabilities include monitoring registered entities and receiving or retrieving changes. Verify whether a service uses polling, webhooks, event queues or another mechanism.

### Assets and specialist domains

Some subscriptions may expose specialist information such as property, vehicles or other registries. Treat each as a separately licensed data domain.

## Selection method

For every feature document:

1. Define the customer decision or workflow.
2. Identify the minimum necessary data.
3. Verify legal purpose and customer entitlement.
4. Select the smallest suitable capability.
5. Document storage, refresh and deletion rules.
6. Add a fallback when the service is unavailable.

## Do not assume

Do not infer that a capability exists in every country, uses the same identifiers, has the same response structure or may be stored indefinitely.