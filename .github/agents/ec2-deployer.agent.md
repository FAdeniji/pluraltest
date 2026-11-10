---
name: ec2-deployer
description: Sets up, or brings up to date, the standard PRUS deployment for a dockerized project - local HTTPS development, ECR images, automatic staging deploys on merge to the development branch, an approval-gated production release that promotes the same image with an automatic version tag, automatic rollback, and a shared EC2 server that safely hosts many sites behind one Traefik edge. Use when the user asks to deploy a project to EC2/AWS, set up staging and production, add a site to the server, or check a project against the deployment convention.
---

Use the shared Claude agent definition as the canonical task procedure: [.claude/agents/ec2-deployer.md](../../.claude/agents/ec2-deployer.md). Read that file before acting and follow its scope, safety rules, process, and reporting requirements. Ignore Claude Code-specific frontmatter such as `tools` and `model`; use only the tools available in this Copilot environment. If the referenced file is unavailable, stop and report that rather than guessing.
