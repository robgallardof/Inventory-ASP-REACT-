import React from "react";
import { packageDTO } from "./packages.model";
import css from "./IndividualPackage.module.css";

export default function IndividualPackage(props: packageDTO) {
  const buildLink = () => `/package/${props.id}`;

  return (
    <div className={css.div}>
      <a href={buildLink()}>
        <img alt="Package" src={props.image} />
      </a>
      <p>
        <a href={buildLink()}>{props.name}</a>
      </p>
    </div>
  );
}
