
const card = document.createElement("div");
card.style.width = "350px";
card.style.borderRadius = "10px";
card.style.overflow = "hidden";
card.style.boxShadow = "0 4px 20px rgba(0,0,0,0.2)";
card.style.fontFamily = "Arial, sans-serif";
card.style.background = "#fff";
card.style.margin = "20px auto";


// --- Image ---
const img = document.createElement("img");
img.src = "assets/images/istockphoto-1817070523-1024x1024.jpg"; 
img.style.width = "100%";
img.style.height = "200px";
img.style.objectFit = "cover";
card.appendChild(img);



const content = document.createElement("div");
content.style.padding = "20px";

const title = document.createElement("h3");
title.innerText = "DETACHED HOUSE • 5Y OLD";
title.style.fontSize = "14px";
title.style.letterSpacing = "1px";
title.style.color = "#555";
title.style.margin = "0 0 10px";
content.appendChild(title);



const price = document.createElement("h1");
price.innerText = "$750,000";
price.style.fontSize = "28px";
price.style.margin = "0";
content.appendChild(price);


const address = document.createElement("p");
address.innerText = "742 Evergreen Terrace";
address.style.margin = "5px 0 20px";
address.style.color = "#666";
address.style.fontSize = "14px";
content.appendChild(address);



const features = document.createElement("div");
features.style.display = "flex";
features.style.justifyContent = "space-between";
features.style.marginBottom = "20px";


const bed = document.createElement("div");
bed.innerHTML = "🛏️ 3 Bedrooms";
bed.style.fontSize = "14px";


const bath = document.createElement("div");
bath.innerHTML = "🛁 2 Bathrooms";
bath.style.fontSize = "14px";

features.appendChild(bed);
features.appendChild(bath);

content.appendChild(features);



const realtorLabel = document.createElement("p");
realtorLabel.innerText = "REALTOR";
realtorLabel.style.fontSize = "12px";
realtorLabel.style.color = "#999";
realtorLabel.style.marginBottom = "8px";
content.appendChild(realtorLabel);

const realtor = document.createElement("div");
realtor.style.display = "flex";
realtor.style.alignItems = "center";

const avatar = document.createElement("img");
avatar.src = "assets/images/IMG_8458.JPG"; 
avatar.style.width = "40px";
avatar.style.height = "40px";
avatar.style.borderRadius = "50%";
avatar.style.marginRight = "10px";

const realtorInfo = document.createElement("div");
realtorInfo.innerHTML = `
    <strong>Tiffany Heffner</strong><br>
    <span style="color:#777">(555) 555-4321</span>
`;

realtor.appendChild(avatar);
realtor.appendChild(realtorInfo);

content.appendChild(realtor);



card.appendChild(content);



document.body.appendChild(card);