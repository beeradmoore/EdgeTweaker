
// via https://stackoverflow.com/a/75065536
// Set theme to the user's preferred color scheme
function updateTheme() {
	const colorMode = window.matchMedia("(prefers-color-scheme: dark)").matches ? "dark" : "light";
	document.querySelector("html").setAttribute("data-bs-theme", colorMode);
}

// Set theme on load
updateTheme();

// Update theme when the preferred scheme changes
window.matchMedia('(prefers-color-scheme: dark)').addEventListener('change', updateTheme);

var jsonData;
var settings = {};

function resizeIframe(iframe) {
	//console.log(resizeIframe);
	iframe.style.height = iframe.contentWindow.document.body.scrollHeight + 'px';
}

function createRadioGroupItem(group_name, text, value, checked, enabled) {
	const formDiv = document.createElement("div");
	formDiv.classList.add("form-check");

	const input = document.createElement("input");
	input.classList.add("form-check-input");
	input.type = "radio";
	input.name = group_name;
	input.id = value;
	input.value = value;

	if (checked) {
		input.setAttribute("checked", "checked");
	}

	if (enabled == false) {
		input.setAttribute("disabled", "disabled");
	}

	const label = document.createElement("label");
	label.classList.add("form-check-label");
	label.setAttribute("for", value);
	label.appendChild(document.createTextNode(text));

	formDiv.appendChild(input);
	formDiv.appendChild(label);

	return formDiv;
}

function createCheckBoxItem(text, value, checked, enabled) {
	const formDiv = document.createElement("div");
	formDiv.classList.add("form-check");

	const input = document.createElement("input");
	input.classList.add("form-check-input");
	input.type = "checkbox";
	input.id = value;
	input.name = value;
	input.value = value;

	if (checked) {
		input.setAttribute("checked", "checked");
	}

	if (enabled == false) {
		input.setAttribute("disabled", "disabled");
	}

	const label = document.createElement("label");
	label.classList.add("form-check-label");
	label.setAttribute("for", value);
	label.appendChild(document.createTextNode(text));

	formDiv.appendChild(input);
	formDiv.appendChild(label);

	return formDiv;
}

function showExportModal() {

	const exportModalDiv = document.createElement("div");
	exportModalDiv.id = "exportModal";
	exportModalDiv.classList.add("modal");
	exportModalDiv.tabIndex = -1;

	const modalDialog = document.createElement("div");
	modalDialog.classList.add("modal-dialog");
	modalDialog.classList.add("modal-dialog-scrollable");
	modalDialog.classList.add("modal-lg");

	const modalContent = document.createElement("div");
	modalContent.classList.add("modal-content");

	const modalHeader = document.createElement("div");
	modalHeader.classList.add("modal-header");

	const modalTitle = document.createElement("h3");
	modalTitle.classList.add("modal-title");
	modalTitle.appendChild(document.createTextNode("Export"));

	const modalCloseButton = document.createElement("button");
	modalCloseButton.type = "button";
	modalCloseButton.classList.add("btn-close");
	modalCloseButton.setAttribute('data-bs-dismiss', 'modal');
	modalCloseButton.setAttribute('aria-label', 'Close');

	modalHeader.appendChild(modalTitle);
	modalHeader.appendChild(modalCloseButton);

	const modalBody = document.createElement("div");
	modalBody.classList.add("modal-body");
	modalBody.style = "display: flex; flex-direction: column; height: 100%;";

	const alertDiv = document.createElement("div");
	alertDiv.classList.add("alert");
	alertDiv.classList.add("alert-warning");
	alertDiv.setAttribute('role', 'alert');
	alertDiv.appendChild(document.createTextNode("While these exports should be safe to use, by continuing you agree to use these them at your own risk. As always, have a backup in case things go wrong."));
	modalBody.appendChild(alertDiv);

	const infoDiv = document.createElement("div");
	infoDiv.classList.add("mb-3");
	infoDiv.innerHTML = 'See the project <a href="https://github.com/beeradmoore/edgetweaker" target="_blank">readme</a> on how to use these different exports.';

	modalBody.appendChild(infoDiv);

	const windowsDiv = document.createElement("div");
	windowsDiv.classList.add("mb-3");

	const windowsButtonsDiv = document.createElement("div");
	windowsButtonsDiv.classList.add("d-flex");
	windowsButtonsDiv.classList.add("flex-wrap")
	windowsButtonsDiv.classList.add("mb-3");
	windowsButtonsDiv.classList.add("gap-2");

	const windowsHeading = document.createElement("h5");
	windowsHeading.appendChild(
		document.createTextNode("Windows")
	);

	const groupPolicyButton = document.createElement("button");
	groupPolicyButton.type = "button";
	groupPolicyButton.classList.add("btn");
	groupPolicyButton.classList.add("disabled"); // Group policy is not currently supported
	groupPolicyButton.classList.add("btn-primary");
	groupPolicyButton.appendChild(document.createTextNode("Group Policy (ADMX)"));
	groupPolicyButton.onclick = function () {
		exportWindowsGroupPolicy();
	};
	windowsButtonsDiv.appendChild(groupPolicyButton);

	const registryButton = document.createElement("button");
	registryButton.type = "button";
	registryButton.classList.add("btn");
	registryButton.classList.add("btn-primary");
	registryButton.appendChild(document.createTextNode("Registry"));
	registryButton.onclick = function () {
		exportWindowsRegistry();
	};
	windowsButtonsDiv.appendChild(registryButton);

	windowsDiv.appendChild(windowsButtonsDiv);


	const edgeRegCleanerTag = document.createElement("a");
	edgeRegCleanerTag.href = "EdgeRegCleanup.reg";
	edgeRegCleanerTag.setAttribute("download", "EdgeRegCleanup.reg");
	edgeRegCleanerTag.appendChild(document.createTextNode("EdgeRegCleanup.reg"));
	windowsDiv.appendChild(edgeRegCleanerTag);

	const macOSDiv = document.createElement("div");
	macOSDiv.classList.add("mb-3");

	const macOSButtonsDiv = document.createElement("div");
	macOSButtonsDiv.classList.add("d-flex");
	macOSButtonsDiv.classList.add("flex-wrap")
	macOSButtonsDiv.classList.add("mb-3");
	macOSButtonsDiv.classList.add("gap-2");

	const macOSHeading = document.createElement("h5");
	macOSHeading.appendChild(document.createTextNode("macOS"));

	const pListInstallerBundle = document.createElement("button");
	pListInstallerBundle.type = "button";
	pListInstallerBundle.classList.add("btn");
	pListInstallerBundle.classList.add("btn-primary");
	pListInstallerBundle.appendChild(document.createTextNode("Installer bundle"));
	pListInstallerBundle.onclick = function () {
		exportMacOSPlist('installer_bundle');
	};
	macOSButtonsDiv.appendChild(pListInstallerBundle);

	const pListMandatoryButton = document.createElement("button");
	pListMandatoryButton.type = "button";
	pListMandatoryButton.classList.add("btn");
	pListMandatoryButton.classList.add("btn-primary");
	pListMandatoryButton.appendChild(document.createTextNode("Plist (only mandatory options)"));
	pListMandatoryButton.onclick = function () {
		exportMacOSPlist('mandatory');
	};
	macOSButtonsDiv.appendChild(pListMandatoryButton);

	const pListRecommendedButton = document.createElement("button");
	pListRecommendedButton.type = "button";
	pListRecommendedButton.classList.add("btn");
	pListRecommendedButton.classList.add("btn-primary");
	pListRecommendedButton.appendChild(document.createTextNode("Plist (only recommended options)"));
	pListRecommendedButton.onclick = function () {
		exportMacOSPlist('recommended');
	};
	macOSButtonsDiv.appendChild(pListRecommendedButton);

	macOSDiv.appendChild(macOSButtonsDiv);

	const macOSEnablerTool = document.createElement("a");
	macOSEnablerTool.href = "https://github.com/beeradmoore/edgetweaker?#macos-enabler-tool";
	macOSEnablerTool.target = "_blank";
	macOSEnablerTool.appendChild(document.createTextNode("macOS enabler tool"));
	macOSDiv.appendChild(macOSEnablerTool);


	modalBody.appendChild(windowsHeading);
	modalBody.appendChild(windowsDiv);
	modalBody.appendChild(macOSHeading);
	modalBody.appendChild(macOSDiv);


	modalContent.appendChild(modalHeader);
	modalContent.appendChild(modalBody);

	modalDialog.appendChild(modalContent);

	exportModalDiv.appendChild(modalDialog);

	exportModalDiv.addEventListener('hidden.bs.modal', event => {
		document.body.removeChild(exportModalDiv);
		//exportModalDiv.dispose();
	});

	document.body.appendChild(exportModalDiv);

	const exportModal = new bootstrap.Modal(exportModalDiv, []);

	exportModal.show();
}

function getEnabledPolicies() {
	var enabledPolicies = {};
	for (const [key, value] of Object.entries(settings)) {
		let foundPolicy = false;
		for (const [policyGroupId, policyGroup] of Object.entries(jsonData.policy_groups)) {
			for (const [policyId, policy] of Object.entries(policyGroup.policies)) {
				if (policy.id == key) {
					enabledPolicies[policy.id] = policy;
					foundPolicy = true;
					break;
				}
			}

			if (foundPolicy) {
				break;
			}
		}
	}
	return enabledPolicies;
}

function exportWindowsGroupPolicy() {
	const enabledPolicies = getEnabledPolicies();
	// TODO:
}

function exportWindowsRegistry() {
	const enabledPolicies = getEnabledPolicies();

	var regFileKeys = {};

	for (const [key, setting] of Object.entries(settings)) {
		const policy = enabledPolicies[key];
		if (policy == undefined) {
			console.error("Could not find policy for key " + key);
			debugger;
			continue;
		}

		try {

			if (policy.platform_windows == true) {

				let regKey = undefined;
				let regValueName = undefined;
				let regValueData = undefined;

				if (setting.mandatory_or_recommended == "mandatory") {
					regKey = "HKEY_CURRENT_USER\\" + policy.windows_registry_mandatory_path;
				}
				else if (mandatory_or_recommended == "recommended") {
					regKey = "HKEY_CURRENT_USER\\" + policy.windows_registry_recommended_path;
				}

				regValueName = policy.windows_registry_value_name;

				if (policy.windows_registry_value_type == "REG_DWORD") {
					if (policy.data_type == "integer") {
						regValueData = "dword:" + (setting.value).toString(16).padStart(8, '0');
					}
					else if (policy.data_type == "boolean") {
						if (setting.value == true) {
							regValueData = "dword:00000001";
						}
						else {
							regValueData = "dword:00000000";
						}
					}
				}
				else if (policy.windows_registry_value_type == "REG_SZ") {
					if (policy.data_type == "string") {
						// Append double quotes to the string
						regValueData = "\"" + setting.value + "\"";
					}
					else if (policy.data_type == "dictionary") {
						// Minify json and escape double quotes
						regValueData = "\"" + JSON.stringify(JSON.parse(setting.value)).replaceAll("\"", "\\\"") + "\"";
					}
				}
				else if (policy.windows_registry_value_type == "list of REG_SZ") {

					// Split string into an array, and then filter out blank lines
					regValueData = setting.value.split('\n').filter(item => item.trim() !== '');

					// Foreach item, check if it is an json by first trying to do json.parse.
					// If it is minify and escape double quotes like we did for dictionary and add its double quotes to the ends
					// If not, just add its double quotes to the ends.
					for (let i = 0; i < regValueData.length; ++i) {
						try {
							const parsedJson = JSON.parse(regValueData[i]);
							regValueData[i] = "\"" + JSON.stringify(parsedJson).replaceAll("\"", "\\\"") + "\"";
						} catch (e) {
							regValueData[i] = "\"" + regValueData[i] + "\"";
						}
					}
				}
				else {
					console.error("Unknown windows_registry_value_type for policy " + policy.name);
					debugger;
				}

				if (regKey != undefined && regValueName != undefined && regValueData != undefined) {

					if (regFileKeys[regKey] == undefined) {
						regFileKeys[regKey] = [];
					}

					// Handle "list of REG_SZ" differently to every other type, its already split into an array
					// Now we nee to make each item be its own data entry.
					if (policy.windows_registry_value_type == "list of REG_SZ") {
						for (let i = 0; i < regValueData.length; ++i) {
							regFileKeys[regKey].push("\"" + (i + 1) + "\"=" + regValueData[i]);
						}
						regValueData = setting.value.split('\n');
					}
					else {
						regFileKeys[regKey].push("\"" + regValueName + "\"=" + regValueData);
					}
				}
			}
		}
		catch (e) {
			alert('Error exporting policy: ' + policy.id);
			return;
		}
	}


	let regFile = 'Windows Registry Editor Version 5.00\n\n; Created with EdgeTweaker\n; https://beeradmoore.github.io/EdgeTweaker/\n\n';

	for (const [regKey, regEntry] of Object.entries(regFileKeys)) {
		regFile += "[" + regKey + "]\n";

		for (var i = 0; i < regEntry.length; ++i) {
			regFile += regEntry[i] + "\n";
		}

		regFile += "\n";
	}

	const blob = new Blob([regFile], { type: 'text/plain' });
	const url = URL.createObjectURL(blob);
	const a = document.createElement('a');
	a.href = url;
	a.download = 'EdgeTweaker-Policies.reg';
	document.body.appendChild(a);
	a.click();
	document.body.removeChild(a);
	URL.revokeObjectURL(url);

}

function exportMacOSPlist(export_type) {
	const enabledPolicies = getEnabledPolicies();

	if (export_type == 'mandatory') {
		const mandatoryPlist = generateMacOSPlist("mandatory", enabledPolicies);

		const blob = new Blob([mandatoryPlist], { type: 'application/x-plist' });
		const url = URL.createObjectURL(blob);
		const a = document.createElement('a');
		a.href = url;
		a.download = 'com.microsoft.Edge.plist';
		document.body.appendChild(a);
		a.click();
		document.body.removeChild(a);
		URL.revokeObjectURL(url);
	}
	else if (export_type == 'recommended') {
		const recommendedPlist = generateMacOSPlist("recommended", enabledPolicies);

		const blob = new Blob([recommendedPlist], { type: 'application/x-plist' });
		const url = URL.createObjectURL(blob);
		const a = document.createElement('a');
		a.href = url;
		a.download = 'com.microsoft.Edge.plist';
		document.body.appendChild(a);
		a.click();
		document.body.removeChild(a);
		URL.revokeObjectURL(url);
	}
	else if (export_type == 'installer_bundle') {


		const mandatoryPlist = generateMacOSPlist("mandatory", enabledPolicies);
		const recommendedPlist = generateMacOSPlist("recommended", enabledPolicies);

		const zip = new JSZip();

		const mandatoryFolder = zip.folder("mandatory");
		mandatoryFolder.file("com.microsoft.Edge.plist", mandatoryPlist);

		const recommendedFolder = zip.folder("recommended");
		recommendedFolder.file("com.microsoft.Edge.plist", recommendedPlist);

		zip.generateAsync({type:"blob"}).then(function(content) {
			const url = URL.createObjectURL(content);
			const a = document.createElement('a');
			a.href = url;
			a.download = 'edgetweaker-settings.zip';
			document.body.appendChild(a);
			a.click();
			document.body.removeChild(a);
			URL.revokeObjectURL(url);
		});
				/*
zip.file("Hello.txt", "Hello World\n");
zip.file("script.sh", "#!/bin/bash", {
    unixPermissions: "755"
});
*/
	}



}

function generateMacOSPlist(mandatory_or_recommended, enabledPolicies) {
	if (mandatory_or_recommended != "mandatory" && mandatory_or_recommended != "recommended")
	{
		return "";
	}
	let plist = `<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<!-- Created with EdgeTweaker -->
<!-- https://beeradmoore.github.io/EdgeTweaker/ -->
<!-- Policy type: ${mandatory_or_recommended} -->
<plist version="1.0">
<dict>
`;

	for (const [key, value] of Object.entries(settings)) {
		// Only put the policy here if it is recommended or mandatory
		if (value.mandatory_or_recommended != mandatory_or_recommended) {
			continue;
		}

		const policy = enabledPolicies[key];
		if (policy == undefined) {
			console.error("Could not find policy for key " + key);
			debugger;
			continue;
		}

		try {

			if (policy.platform_macos == true) {
				plist += `    <key>${policy.macos_preference_key_name}</key>
`;
				if (policy.data_type == "string") {
					// Escape &
					let stringValue = value.value.replaceAll("&", "&amp;");
					plist += `    <string>${stringValue}</string>
`;
				}
				else if (policy.data_type == "integer") {
					plist += `    <integer>${value.value}</integer>
`;
				}
				else if (policy.data_type == "boolean") {
					if (value.value == true) {
						plist += `    <true/>
`;
					}
					else if (value.value == false) {
						plist += `    <false/>
`;
					}
				}
				else if (policy.data_type == "list_of_strings") {
					plist += `    <array>
`;
					value.value.split('\n').forEach(function (stringValue) {
						plist += `        <string>${stringValue.replaceAll("&", "&amp;")}</string>
`;
					});
					plist += `    </array>
`;
				}
				else if (policy.data_type == "dictionary") {
					const json = JSON.parse(value.value);

					if (Array.isArray(json)) {
						plist += jsonObjectToPlistNode(json, '    ');
					}
					else
					{
						plist += jsonObjectToPlist(json, '    ');
					}

				}
				else {
					console.error("Unknown data_type for policy " + policy.name);
					debugger;
				}
			}
		}
		catch (e) {
			alert('Error exporting policy: ' + policy.id);
			return;
		}
	}

	plist += `</dict>
</plist>`;

	return plist;
}

function jsonObjectToPlist(obj, indent = "") {
	let plistContent = `${indent}<dict>\n`;

	for (const [key, value] of Object.entries(obj)) {
		plistContent += `${indent}    <key>${key}</key>\n`;
		plistContent += jsonObjectToPlistNode(value, indent);
	}

	plistContent += `${indent}</dict>\n`;
	return plistContent;
}


function jsonObjectToPlistNode(value, indent = "") {
	let plistContent = '';

	if (typeof value === 'object' && value !== null) {
		if (Array.isArray(value)) {
			plistContent += `${indent}    <array>\n`;
			value.forEach(item => {
				plistContent += jsonObjectToPlistNode(item, `${indent}        `);
			});
			plistContent += `${indent}    </array>\n`;
		} else {
			plistContent += jsonObjectToPlist(value, indent + "    ");
		}
	} else if (typeof value === 'boolean') {
		plistContent += `${indent}    <${value}/>\n`;
	} else if (typeof value === 'string') {
		plistContent += `${indent}    <string>${value.replaceAll("&", "&amp;")}</string>\n`;
	} else if (typeof value === 'number') {
		plistContent += `${indent}    <integer>${value}</integer>\n`;
	}
	else {
		console.error("Unknown type while generating plist: " + typeof value);
		debugger;
	}

	return plistContent;
}

function showModal(policy, cardDiv) {
	const settingsModalDiv = document.createElement("div");
	settingsModalDiv.id = "settingsModal";
	settingsModalDiv.classList.add("modal");
	settingsModalDiv.tabIndex = -1;

	const modalDialog = document.createElement("div");
	modalDialog.classList.add("modal-dialog");
	modalDialog.classList.add("modal-dialog-scrollable");
	modalDialog.classList.add("modal-lg");

	const modalContent = document.createElement("div");
	modalContent.classList.add("modal-content");

	const modalHeader = document.createElement("div");
	modalHeader.classList.add("modal-header");

	const modalTitle = document.createElement("h3");
	modalTitle.classList.add("modal-title");
	modalTitle.appendChild(document.createTextNode(policy.name));

	const modalCloseButton = document.createElement("button");
	modalCloseButton.type = "button";
	modalCloseButton.classList.add("btn-close");
	modalCloseButton.setAttribute('data-bs-dismiss', 'modal');
	modalCloseButton.setAttribute('aria-label', 'Close');

	modalHeader.appendChild(modalTitle);
	modalHeader.appendChild(modalCloseButton);

	const modalBody = document.createElement("div");
	modalBody.classList.add("modal-body");
	//modalBody.style = "display: flex; flex-direction: column; height: 100%;";
	modalBody.style = "overflow: auto; flex-grow: 1;";


	const modalSubTitle = document.createElement("h5");
	modalSubTitle.classList.add("modal-subtitle");
	modalSubTitle.classList.add("mb-2");
	modalSubTitle.id = "microsoft-edge---policies"; // lol
	modalSubTitle.appendChild(document.createTextNode(policy.id));
	modalBody.appendChild(modalSubTitle);


	// Add a notice if the policy may not be supported by this tool yet.
	if (policy.supported == false) {
		const notSupportedDiv = document.createElement("div");
		notSupportedDiv.classList.add("alert");
		notSupportedDiv.classList.add("alert-danger");
		notSupportedDiv.setAttribute('role', 'alert');
		notSupportedDiv.appendChild(document.createTextNode("This property may not be fully supported by this tool at this time."));

		modalBody.appendChild(notSupportedDiv);
	}

	// Add a notice if the policy has warnings
	if (policy.warnings != undefined && policy.warnings.length > 0) {
		for (var i = 0; i < policy.warnings.length; ++i) {
			const warningDiv = document.createElement("div");
			warningDiv.classList.add("alert");
			warningDiv.classList.add("alert-warning");
			warningDiv.setAttribute('role', 'alert');
			warningDiv.appendChild(document.createTextNode(policy.warnings[i]));

			modalBody.appendChild(warningDiv);
		}
	}
	var settingDiv = undefined;

	if (policy.data_type == "dictionary") {
		settingDiv = document.createElement("div");
		settingDiv.classList.add("mb-2");

		/*
		const settingDivLabel = document.createElement("label");
		settingDivLabel.classList.add("form-label");
		settingDivLabel.appendChild(document.createTextNode("JSON dictionary:"));
		settingDiv.appendChild(settingDivLabel);
		*/

		const textInput = document.createElement("textarea");
		textInput.classList.add("form-control");
		textInput.rows = 10;
		textInput.id = "policy-text";

		// Set the existing value if it exists.
		if (settings[policy.id] != undefined) {
			textInput.value = settings[policy.id].value;
		}

		// If the Windows example does not exist, use the macOS one.
		if (policy.windows_registry_example_value != "") {
			textInput.placeholder = policy.windows_registry_example_value;
		}
		else {
			textInput.placeholder = "JSON dictionary"
		}

		settingDiv.appendChild(textInput);
	}
	else if (policy.data_type == "boolean") {

		settingDiv = document.createElement("div");
		settingDiv.classList.add("mb-2");

		const settingDivLabel = document.createElement("label");
		settingDivLabel.classList.add("form-label");
		settingDivLabel.appendChild(document.createTextNode("Setting:"));
		settingDiv.appendChild(settingDivLabel);

		let isEnabled = false;
		let isDisabled = false;

		// Set the existing value if it exists.
		if (settings[policy.id] != undefined) {
			if (settings[policy.id].value == true) {
				isEnabled = true;
			}
			else if (settings[policy.id].value == false) {
				isDisabled = true;
			}
		}

		const isEnabledDiv = createRadioGroupItem("is_enabled", "Enabled", "enabled", isEnabled, true);
		const isDisabledDiv = createRadioGroupItem("is_enabled", "Disabled", "disabled", isDisabled, true);

		settingDiv.appendChild(isEnabledDiv);
		settingDiv.appendChild(isDisabledDiv);
	}
	else if (policy.data_type == "string") {
		settingDiv = document.createElement("div");
		settingDiv.classList.add("mb-2");
		//settingDiv.classList.add("form-check");
		const textInput = document.createElement("input");
		textInput.classList.add("form-control");
		textInput.type = "text";
		textInput.id = "policy-text";

		// Set the existing value if it exists.
		if (settings[policy.id] != undefined) {
			textInput.value = settings[policy.id].value;
		}

		// If the Windows example does not exist, use the macOS one.
		if (policy.windows_registry_example_value != "") {
			textInput.placeholder = policy.windows_registry_example_value;
		}
		else {
			textInput.placeholder = policy.macos_preference_example_value.replaceAll('<string>', '').replaceAll('</string>', '');
		}

		settingDiv.appendChild(textInput);
	}
	else if (policy.data_type == "list_of_strings") {

		settingDiv = document.createElement("div");
		settingDiv.classList.add("mb-2");


		const settingDivLabel = document.createElement("label");
		settingDivLabel.classList.add("form-label");
		settingDivLabel.appendChild(document.createTextNode("One entry per line:"));
		settingDiv.appendChild(settingDivLabel);

		const textInput = document.createElement("textarea");
		textInput.classList.add("form-control");
		textInput.rows = 10;
		textInput.id = "policy-text";

		// Set the existing value if it exists.
		if (settings[policy.id] != undefined) {
			textInput.value = settings[policy.id].value;
		}

		// If the Windows example does not exist, use the macOS one.
		if (policy.windows_registry_example_value != "") {
			textInput.placeholder = policy.windows_registry_example_value.replaceAll('\\"', '\"');
		}
		else {
			textInput.placeholder = "Each entry on a new line"
		}

		settingDiv.appendChild(textInput);

	}
	else if (policy.data_type == "integer") {
		settingDiv = document.createElement("div");
		settingDiv.classList.add("mb-2");
		const textInput = document.createElement("input");
		textInput.classList.add("form-control");
		textInput.type = "number";
		textInput.id = "policy-text";

		// Set the existing value if it exists.
		if (settings[policy.id] != undefined) {
			textInput.value = settings[policy.id].value;
		}

		if (policy.windows_registry_example_value != "") {
			// Windows examples are base 16, convert it to base 10
			textInput.placeholder = parseInt(policy.windows_registry_example_value);
		}
		else {
			// macOS examples have integer tags around it, so strip them.
			textInput.placeholder = policy.macos_preference_example_value.replaceAll('<integer>', '').replaceAll('</integer>', '');
		}
		settingDiv.appendChild(textInput);
	}
	else {
		console.error("Unknown data_type for policy " + policy.name);
		debugger;
	}

	if (settingDiv != undefined) {
		/*
		var settingWrapperDiv = document.createElement("div");
		settingWrapperDiv.classList.add("mb-2");
		settingWrapperDiv.appendChild(settingDiv);
		modalBody.appendChild(settingWrapperDiv);
		*/
		modalBody.appendChild(settingDiv);

		// Check that policy_mapping is defined
		if (policy.policy_mapping != undefined) {
			// Also check it has items
			var policyMappingEntries = Object.entries(policy.policy_mapping);
			if (policyMappingEntries.length > 0) {
				// Create a row for the buttons
				const policyMappingDiv = document.createElement("div");
				policyMappingDiv.classList.add("d-flex");
				policyMappingDiv.classList.add("flex-wrap");
				policyMappingDiv.classList.add("gap-2");
				policyMappingDiv.classList.add("mb-2");

				// For every policy mapping item add it here.
				for (const [key, value] of policyMappingEntries) {
					const mappingButton = document.createElement("button");
					mappingButton.classList.add("btn");
					mappingButton.classList.add("btn-primary");
					mappingButton.appendChild(document.createTextNode(value));
					policyMappingDiv.appendChild(mappingButton);

					// And when this button is clicked, set the text input to the key.
					mappingButton.addEventListener('click', function () {
						var policyTextInput = document.getElementById("policy-text");
						if (policyTextInput != undefined) {
							policyTextInput.value = key;
						}
					});
				}

				modalBody.appendChild(policyMappingDiv);
			}
		}
	}


	let isMandatory = false;
	let isRecommended = false;

	if (policy.can_be_mandatory == true && policy.can_be_recommended == true) {
		// Set the existing value if it exists, otherwise default to recommended.
		if (settings[policy.id] == undefined) {
			isRecommended = true;
		}
		else {
			var mandatoryOrRecommended = settings[policy.id].mandatory_or_recommended;
			if (mandatoryOrRecommended == "mandatory") {
				isMandatory = true;
			}
			else if (mandatoryOrRecommended == "recommended") {
				isRecommended = true;
			}
			else {
				// Fallback
				isRecommended = true;
			}
		}
	}
	else if (policy.can_be_mandatory == true && policy.can_be_recommended == false) {
		isMandatory = true;
	}
	else if (policy.can_be_mandatory == false && policy.can_be_recommended == true) {
		isRecommended = true;
	}

	// Show both options as a radio button
	const mandatoryDiv = createRadioGroupItem("can_be_mandatory_recommended", "Mandatory", "can_be_mandatory", isMandatory, policy.can_be_mandatory);
	const recommendedDiv = createRadioGroupItem("can_be_mandatory_recommended", "Recommended", "can_be_recommended", isRecommended, policy.can_be_recommended);


	const mandatoryRecommendedWrapperDiv = document.createElement("div");
	const mandatoryRecommendedWrapperLabel = document.createElement("label");
	mandatoryRecommendedWrapperLabel.classList.add("form-label");
	mandatoryRecommendedWrapperLabel.appendChild(document.createTextNode("Set as mandatory or recommended:"));

	mandatoryRecommendedWrapperDiv.appendChild(mandatoryRecommendedWrapperLabel);
	mandatoryRecommendedWrapperDiv.appendChild(mandatoryDiv);
	mandatoryRecommendedWrapperDiv.appendChild(recommendedDiv);
	modalBody.appendChild(mandatoryRecommendedWrapperDiv);

	const bodySeparator = document.createElement("hr");
	bodySeparator.classList.add("mx-0");
	bodySeparator.classList.add("mb-0");
	modalBody.appendChild(bodySeparator);

	const converter = new showdown.Converter();
	converter.setOption('noHeaderId', true);

	// Replace the header and subheader, as the dialog already has them.
	// This could be done in the markdown, but we also want to keep the markdown
	// as true to form as it originally was.

	let markdown = policy.markdown;
	markdown = markdown.replace(/^###.*$/m, '');
	markdown = markdown.replace(/^####.*$/m, '');

	const docsDiv = document.createElement("div");
	docsDiv.innerHTML = converter.makeHtml(markdown);
	modalBody.appendChild(docsDiv);

	const bodySeparator2 = document.createElement("hr");
	bodySeparator2.classList.add("mx-0");
	bodySeparator2.classList.add("mt-0");
	modalBody.appendChild(bodySeparator2);

	const docsSpan = document.createElement("span");
	docsSpan.appendChild(document.createTextNode("Source: "));

	const docsLink = document.createElement("a");
	docsLink.href = "https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies#" + policy.link;
	docsLink.target = "_blank";
	docsLink.appendChild(document.createTextNode("Microsoft Edge Browser Policy Documentation | Microsoft Learn"));
	docsSpan.appendChild(docsLink);
	modalBody.appendChild(docsSpan);

	const modalFooter = document.createElement("div");
	modalFooter.classList.add("modal-footer");
	modalFooter.classList.add("justify-content-between");

	const clearButton = document.createElement("button");
	clearButton.type = "button";
	clearButton.classList.add("btn");
	clearButton.classList.add("btn-danger");
	clearButton.classList.add("me-auto");

	clearButton.appendChild(document.createTextNode("Clear"));

	const closeButton = document.createElement("button");
	closeButton.type = "button";
	closeButton.classList.add("btn");
	closeButton.classList.add("btn-secondary");
	closeButton.setAttribute("data-bs-dismiss", "modal");
	closeButton.appendChild(document.createTextNode("Close"));

	const saveButton = document.createElement("button");
	saveButton.type = "button";
	saveButton.classList.add("btn");
	saveButton.classList.add("btn-success");
	saveButton.appendChild(document.createTextNode("Save"));

	modalFooter.appendChild(clearButton);
	modalFooter.appendChild(closeButton);
	modalFooter.appendChild(saveButton);

	modalContent.appendChild(modalHeader);
	modalContent.appendChild(modalBody);
	modalContent.appendChild(modalFooter);

	modalDialog.appendChild(modalContent);

	settingsModalDiv.appendChild(modalDialog);

	settingsModalDiv.addEventListener('hidden.bs.modal', event => {
		document.body.removeChild(settingsModalDiv);
		//settingsModalDiv.dispose();
	});

	document.body.appendChild(settingsModalDiv);

	const settingsModal = new bootstrap.Modal(settingsModalDiv, []);

	// Update modal links
	modalBody.querySelectorAll('a').forEach(link => {
		const linkUrl = new URL(link.href);

		// If it goes to the same site show/hide modals
		if (linkUrl.origin == window.location.origin) {
			if (linkUrl.hash == "#microsoft-edge---policies") {
				// NOOP
			}
			else {
				link.onclick = function () {
					var linkName = linkUrl.hash.replace('#', '');
					const newCardForModal = document.querySelector('div[data-policy-link="' + linkName + '"]');
					if (newCardForModal != null) {
						const continueWithoutSaving = confirm("Open new setting without saving your changes?");

						if (continueWithoutSaving == true) {
							settingsModal.hide();
							newCardForModal.click();
						}
					}
				};
			}
		}
		else {
			// If its an external site, open in new tab
			link.target = '_blank';
		}
	});


	clearButton.onclick = function () {
		// Get all input types in this div
		const settingInputs = settingsModalDiv.querySelectorAll('input');
		// For each one, clear its value
		settingInputs.forEach(input => {
			if (input.type == "text" || input.type == "number") {
				input.value = "";
			}
			else if (input.type == "checkbox" || input.type == "radio") {
				input.checked = false;
			}
			else {
				debugger;
			}
		});

		// Get all textarea types in this div
		const settingTextArea = settingsModalDiv.querySelectorAll('textarea');
		// There should only be one, but we will clear all incase this changes in future
		settingTextArea.forEach(textarea => {
			textarea.value = "";
		});
	};

	saveButton.onclick = function () {

		let removeSetting = true;
		let value = undefined;

		if (policy.data_type == "dictionary" || policy.data_type == "list_of_strings") {
			const textInput = settingsModalDiv.querySelector('textarea[id="policy-text"]');

			// Make sure we loaded the property
			if (textInput == null) {
				console.error("Could not find text input for policy \"" + policy.Id + "\"");
				alert("Could not save value for policy \"" + policy.id + "\"");
				return;
			}

			// Check if we have a value, if we don't we are removing it.
			if (textInput.value != "") {
				value = textInput.value;
				removeSetting = false;
			}
		}
		else if (policy.data_type == "boolean") {
			const isEnabledInput = settingsModalDiv.querySelector('input[name="is_enabled"]:checked');
			if (isEnabledInput != null) {
				if (isEnabledInput.value == "enabled") {
					value = true;
					removeSetting = false;
				}
				else if (isEnabledInput.value == "disabled") {
					value = false;
					removeSetting = false;
				}
				else {
					alert("Could not save value for policy \"" + policy.id + "\"");
					return;
				}
			}
		}
		else if (policy.data_type == "string" || policy.data_type == "integer") {

			const textInput = settingsModalDiv.querySelector('input[id="policy-text"]');

			// Make sure we loaded the property
			if (textInput == null) {
				console.error("Could not find text input for policy \"" + policy.Id + "\"");
				alert("Could not save value for policy \"" + policy.id + "\"");
				return;
			}

			// Check if we have a value, if we don't we are removing it.
			if (textInput.value != "") {
				if (policy.data_type == "integer") {
					const number = Number(textInput.value);
					if (Number.isInteger(number) == false) {
						alert("Please input a valid integer.");
						return;
					}

					value = number;
					removeSetting = false;
				}
				else if (policy.data_type == "string") {
					value = textInput.value;
					removeSetting = false;
				}
				else {
					console.error("Unknown data_type for policy " + policy.id);
					debugger;
					return;
				}
			}
		}
		else {
			console.error("Unknown data_type for policy " + policy.id);
			debugger;
			return;
		}

		if (removeSetting == true) {
			if (policy.supported == true) {
				cardDiv.classList.remove("border-success");
			}

			delete settings[policy.id];
		}
		else {
			if (policy.supported == true) {
				if (cardDiv.classList.contains("border-success") == false) {
					cardDiv.classList.add("border-success");
				}
			}

			settings[policy.id] = {
				"value": value,
				"mandatory_or_recommended": "recommended"
			};

			// Default to recommended, and then fall back to mandatory if recommended is not available.
			if (policy.can_be_mandatory == true && policy.can_be_recommended == false) {
				settings[policy.id].mandatory_or_recommended = "mandatory";
			}

			const canBeMandatoryOrRecommendedChecked = settingsModalDiv.querySelector('input[name="can_be_mandatory_recommended"]:checked');
			if (canBeMandatoryOrRecommendedChecked != null) {
				if (canBeMandatoryOrRecommendedChecked.value == "can_be_mandatory") {
					settings[policy.id].mandatory_or_recommended = "mandatory";
				}
				else if (canBeMandatoryOrRecommendedChecked.value == "can_be_recommended") {
					settings[policy.id].mandatory_or_recommended = "recommended";
				}
				else {
					alert("Could not save mandatory or recommended value for policy \"" + policy.id + "\"");
					return;
				}
			}
			else {
				const canBeMandatoryChecked = settingsModalDiv.querySelector('input[name="can_be_mandatory"]:checked');
				const canBeRecommendedChecked = settingsModalDiv.querySelector('input[name="can_be_recommended"]:checked');

				if (canBeMandatoryChecked != null) {
					settings[policy.id].mandatory_or_recommended = "mandatory";
				}
				else if (canBeRecommendedChecked != null) {
					settings[policy.id].mandatory_or_recommended = "recommended";
				}
			}
		}

		settingsModal.hide();
	};
	settingsModal.show();
}

document.addEventListener(
	"DOMContentLoaded",
	function () {
		const mainContainer = document.getElementById("main-container");

		const loadButton = document.getElementById("load-button");
		loadButton.onclick = function () {

			//    <input type="file" id="fileInput" accept=".json" style="display: none;">
			const uploadButton = document.createElement("input");
			uploadButton.type = "file";
			uploadButton.accept = ".json";
			uploadButton.style = "display: none;";
			document.body.appendChild(uploadButton);
			uploadButton.addEventListener("cancel", () => {
				document.body.removeChild(uploadButton);
			});
			uploadButton.addEventListener("change", () => {
				if (uploadButton.files.length == 1) {
					const reader = new FileReader();
					reader.onload = function (e) {
						try {
							const json = JSON.parse(e.target.result);
							settings = json;

							const cardDivs = document.getElementsByClassName("card");
							for (let i = 0; i < cardDivs.length; ++i) {
								const cardDiv = cardDivs[i];

								// Remove border-success from all cards
								if (cardDiv.classList.contains("border-success")) {
									cardDiv.classList.remove("border-success");
								}

								const policyId = cardDiv.getAttribute('data-policy-id');
								if (settings[policyId] != undefined) {
									cardDiv.classList.add("border-success");
								}
							}
						} catch (error) {
							console.error('Error parsing JSON:', error);
							alert('Could not load settings file.');
						}
					};
					reader.readAsText(uploadButton.files[0]);
				}
				document.body.removeChild(uploadButton);
			});


			uploadButton.click();

		};

		const saveButton = document.getElementById("save-button");
		saveButton.onclick = function () {
			const jsonString = JSON.stringify(settings);
			const blob = new Blob([jsonString], { type: 'application/json' });
			const url = URL.createObjectURL(blob);
			const a = document.createElement('a');
			a.href = url;
			a.download = 'edgetweaker-settings.json';
			document.body.appendChild(a);
			a.click();
			document.body.removeChild(a);
			URL.revokeObjectURL(url);
		};

		const exportButton = document.getElementById("export-button");
		exportButton.onclick = function () {
			showExportModal();
		};

		const searchBox = document.getElementById("search-box");
		const searchHandler = function (e) {
			if (e.target.value == "") {
				Object.keys(jsonData.policy_groups).forEach(function (
					policyGroupsKey
				) {
					const policyGroup = jsonData.policy_groups[policyGroupsKey];

					// Show cardDiv again
					Object.keys(policyGroup.policies).forEach(function (policyKey) {
						const policy = policyGroup.policies[policyKey];
						policy.cardDiv.classList.remove("d-none");
					});

					// Show the policyRow again
					policyGroup.policyRow.classList.remove("d-none");
				});
			} else {
				var lowerSearchValue = e.target.value.toLowerCase();

				Object.keys(jsonData.policy_groups).forEach(function (
					policyGroupsKey
				) {
					const policyGroup = jsonData.policy_groups[policyGroupsKey];

					var allHidden = true;

					// Hide cardDiv if it matches the search filter
					Object.keys(policyGroup.policies).forEach(function (policyKey) {
						const policy = policyGroup.policies[policyKey];

						var searchTerms = [
							policy.id.toLowerCase(),
							policy.name.toLowerCase(),
							policy.summary.toLowerCase(),
						];

						for (let i = 0; i < searchTerms.length; ++i) {
							if (searchTerms[i].indexOf(lowerSearchValue) === -1) {
								// Search term was not found, so hide the card
								policy.cardDiv.classList.add("d-none");
							} else {
								// Search term was found, so re-show the card in case it was hidden)
								policy.cardDiv.classList.remove("d-none");

								// There is at least 1 visible card, so we want to ensure the row is shown.
								allHidden = false;

								// I hope this breaks the for loop
								break;
							}
						}
					});

					if (allHidden == true) {
						// Hide the policyRow if all cardDivs were hidden.
						policyGroup.policyRow.classList.add("d-none");
					} else {
						// Show the policyRow if not all of cardDivs were hidden.
						policyGroup.policyRow.classList.remove("d-none");
					}
				});
			}
		};
		searchBox.addEventListener("input", searchHandler);

		var httpRequest = new XMLHttpRequest();
		httpRequest.onreadystatechange = function () {
			if (httpRequest.readyState === 4) {
				if (httpRequest.status === 200) {
					jsonData = JSON.parse(httpRequest.responseText);

					Object.keys(jsonData.policy_groups).forEach(function (
						policyGroupsKey
					) {
						const policyGroup = jsonData.policy_groups[policyGroupsKey];

						const policyRow = document.createElement("div");
						policyRow.classList.add("row");
						policyRow.classList.add("mt-4");
						policyGroup.policyRow = policyRow;

						const policyGroupHeading = document.createElement("h2");
						policyGroupHeading.id = policyGroup.link;
						policyGroupHeading.appendChild(
							document.createTextNode(policyGroup.name)
						);
						policyRow.appendChild(policyGroupHeading);

						const policyGroupDiv = document.createElement("div");
						policyGroupDiv.classList.add("d-flex");
						policyGroupDiv.classList.add("flex-wrap");
						policyGroupDiv.classList.add("gap-3");

						Object.keys(policyGroup.policies).forEach(function (
							policyKey
						) {
							const policy = policyGroup.policies[policyKey];

							const cardDiv = document.createElement("div");
							cardDiv.classList.add("card");
							cardDiv.style = "width: 18rem;";
							cardDiv.setAttribute('data-policy-id', policy.id);
							cardDiv.setAttribute('data-policy-link', policy.link);

							// Handle showing of modal when this card is clicked.
							cardDiv.onclick = function () {
								showModal(policy, cardDiv);
							};

							if (policy.supported == false) {
								cardDiv.classList.add("border-danger");
							}
							policy.cardDiv = cardDiv;

							const cardBody = document.createElement("div");
							cardBody.classList.add("card-body");

							const cardBodyHeader = document.createElement("h5");
							cardBodyHeader.classList.add("card-header");
							cardBodyHeader.appendChild(
								document.createTextNode(policy.name)
							);

							const cardBodySummary = document.createElement("p");
							cardBodySummary.classList.add("card-text");
							cardBodySummary.appendChild(
								document.createTextNode(policy.summary)
							);

							cardDiv.appendChild(cardBodyHeader);
							cardBody.appendChild(cardBodySummary);

							cardDiv.appendChild(cardBody);

							const cardFooter = document.createElement("div");
							cardFooter.classList.add("card-footer");
							cardFooter.appendChild(
								document.createTextNode(policy.data_type)
							);

							cardDiv.appendChild(cardFooter);

							policyGroupDiv.appendChild(cardDiv);
						});

						policyRow.appendChild(policyGroupDiv);

						mainContainer.appendChild(policyRow);
					});

					searchBox.removeAttribute("disabled");
					loadButton.removeAttribute("disabled");
					saveButton.removeAttribute("disabled");
					exportButton.removeAttribute("disabled");
				}
			}
		};
		httpRequest.open("GET", "policy-groups.json");
		httpRequest.send();
	},
	false
);
