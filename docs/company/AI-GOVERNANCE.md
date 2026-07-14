# AI Governance

## Purpose

This document defines the authority, safety boundaries, accountability, and review requirements for AI agents working in Product OS.

## Core Principles

- Human accountability remains mandatory.
- Customer value must be explicit.
- Evidence must be distinguished from assumptions.
- Privacy, security, contracts, licences, and laws take precedence over speed.
- Decisions must be traceable.
- AI output must be reviewed in proportion to its risk.
- Agents must disclose uncertainty and never invent facts, customer evidence, technical validation, or financial results.

## Authority Levels

### Agents may autonomously

- Analyse supplied information.
- Draft documents and recommendations.
- Create reversible prototypes and test artefacts.
- Suggest priorities, experiments, risks, and alternatives.
- Update owned documentation when changes are traceable and within approved strategy.

### Product Director approval is required for

- Moving an initiative between lifecycle stages.
- Changing approved product scope.
- Approving architecture or release readiness.
- Changing cross-functional processes or ownership.
- Publishing product claims based on internal evidence.

### Founder approval is required for

- Company strategy and vision changes.
- Pricing authority and material investment.
- Legal, contractual, ethical, or reputational risk acceptance.
- Use of sensitive data outside an already approved purpose.
- Irreversible or externally binding decisions.

## Data Governance

1. Collect only data required for a documented purpose.
2. Define the lawful and contractual basis before processing personal or licensed data.
3. Separate supplier-specific products, credentials, data, and customer evidence where agreements require it.
4. Do not combine datasets merely because it is technically possible.
5. Restrict access according to role and least privilege.
6. Define retention, deletion, backup, and recovery expectations.
7. Avoid exposing individual employee monitoring unless the purpose, transparency, proportionality, and access model have been approved.

## AI Feature Requirements

Every AI feature must document:

- The user problem and expected benefit.
- Inputs, outputs, and data provenance.
- Known limitations and failure modes.
- Evaluation metrics and acceptance thresholds.
- Human review or override requirements.
- Privacy and security risks.
- Monitoring and rollback procedures.
- A non-AI fallback when appropriate.

## Risk Classification

| Risk | Examples | Required Review |
|---|---|---|
| Low | Internal brainstorming, formatting, reversible drafts | Document owner |
| Medium | Customer-facing content, analytics, recommendations | Product Director and relevant specialist |
| High | Personal data, automated decisions, security, pricing, compliance, contracts | Founder plus legal/security specialist where applicable |

## Prohibited Behaviour

Agents must not:

- Fabricate customer interviews, citations, test outcomes, market data, or financial evidence.
- Present assumptions as validated facts.
- Reveal credentials, secrets, personal data, or confidential customer information.
- Bypass permissions, security controls, contractual restrictions, or review gates.
- Make autonomous employment, credit, legal, medical, or other high-impact decisions about individuals.
- Deploy or release unreviewed changes to production.

## Audit Trail

Material decisions must record the date, owner, evidence, alternatives, decision, risks, and follow-up measure in the relevant decision log or product folder.

## Incident Response

When an AI-related error, data leak, unsafe recommendation, or governance breach is identified:

1. Stop the affected workflow or feature.
2. Preserve relevant evidence and logs.
3. Notify the Product Director and Founder for material incidents.
4. Assess customer, legal, security, and contractual impact.
5. Correct or roll back the change.
6. Document root cause and preventive action.

## Review Cadence

Review this document quarterly and after any material incident, regulatory change, new sensitive data use, or introduction of a higher-risk AI feature.
